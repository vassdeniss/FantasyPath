using AutoMapper;
using FantasyPath.Services.Contracts;
using FantasyPath.Services.Models;
using FantasyPath.Web.Extensions;
using FantasyPath.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FantasyPath.Web.Controllers;

public class BookController(IBookService bookService, ISaveService saveService, IMapper mapper) : Controller
{
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Index(Guid id)
    {
        if (id == Guid.Empty)
        {
            return this.BadRequest("Invalid book ID.");
        }

        ICollection<SaveServiceModel> saves = await saveService.GetBookByIdAndUserWithSavesAsync(
            this.User.Id(),id);
        BookServiceModel book = await bookService.GetBookByIdAsync(id);

        BookSaveViewModel bookSaveModel = new()
        {
            Book = mapper.Map<BookViewModel>(book),
            Saves = mapper.Map<ICollection<SaveViewModel>>(saves)
        };
        
        return this.View(bookSaveModel);
    }
}
