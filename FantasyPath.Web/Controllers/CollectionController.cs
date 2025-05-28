using AutoMapper;
using FantasyPath.Services.Contracts;
using FantasyPath.Services.Models;
using FantasyPath.Web.Extensions;
using FantasyPath.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FantasyPath.Web.Controllers;

public class CollectionController(IBookService bookService, IUserBookService userBookService, IMapper mapper)
    : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        ICollection<BookServiceModel> dbBooks = await userBookService.GetAllBooksForUserAsync(this.User.Id());
        IEnumerable<BookViewModel> books = mapper.Map<IEnumerable<BookViewModel>>(dbBooks);

        return this.View(books);
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Add()
    {
        ICollection<BookServiceModel> userBooks = await userBookService.GetAllBooksForUserAsync(this.User.Id());
        HashSet<Guid> userBookIds = userBooks.Select(ub => ub.Id).ToHashSet();
        ICollection<BookServiceModel> allBooks = await bookService.GetAllBooksAsync();
        IEnumerable<BookServiceModel> books = allBooks.Where(b => !userBookIds.Contains(b.Id))
            .OrderBy(b => b.Order);
        
        return this.View(mapper.Map<IEnumerable<BookViewModel>>(books));
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Add(AddBookFormModel model)
    {
        Guid currentUserId = this.User.Id();
        if (model.UserId != currentUserId)
        {
            return this.Forbid();
        }
        
        await userBookService.AddBookToUserAsync(model.UserId, model.BookId);
        
        return this.RedirectToAction("Index", "Home");
    }
}
