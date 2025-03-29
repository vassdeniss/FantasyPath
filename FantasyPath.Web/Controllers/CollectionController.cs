using AutoMapper;
using FantasyPath.Services.Contracts;
using FantasyPath.Services.Models;
using FantasyPath.Web.Extensions;
using FantasyPath.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FantasyPath.Web.Controllers;

public class CollectionController : Controller
{
    private readonly IBookService _bookService;
    private readonly IMapper _mapper;

    public CollectionController(IBookService bookService, IMapper mapper)
    {
        this._bookService = bookService;
        this._mapper = mapper;
    }
    
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        ICollection<BookServiceModel> dbBooks = await this._bookService.GetAllBooksForUserAsync(this.User.Id());
        IEnumerable<BookViewModel> books = this._mapper.Map<IEnumerable<BookViewModel>>(dbBooks);

        return this.View(books);
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Add()
    {
        ICollection<BookServiceModel> dbBooks = await this._bookService.GetAllBooksUserDoesNotOwnAsync(this.User.Id());
        IEnumerable<BookViewModel> books = this._mapper.Map<IEnumerable<BookViewModel>>(dbBooks);
        
        return this.View(books);
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
        
        await this._bookService.AddBookToUserAsync(model.UserId, model.BookId);
        
        return this.RedirectToAction("Index", "Home");
    }
}
