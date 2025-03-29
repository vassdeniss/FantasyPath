using AutoMapper;
using FantasyPath.Services.Contracts;
using FantasyPath.Services.Models;
using FantasyPath.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FantasyPath.Web.Controllers;

public class BookController : Controller
{
    private readonly IBookService _bookService;
    private readonly IMapper _mapper;

    public BookController(IBookService bookService, IMapper mapper)
    {
        this._bookService = bookService;
        this._mapper = mapper;
    }
    
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Index(Guid id)
    {
        if (id == Guid.Empty)
        {
            return this.BadRequest("Invalid book ID.");
        }
        
        BookServiceModel dbBook = await this._bookService.GetBookByIdWithSavesAsync(id);
        BookViewModel book = this._mapper.Map<BookViewModel>(dbBook);
        
        return this.View(book);
    }
}
