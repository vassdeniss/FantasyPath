using AutoMapper;
using FantasyPath.Services.Contracts;
using FantasyPath.Services.Models;
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
    public IActionResult Index()
    {
        return this.View(Enumerable.Empty<BookViewModel>());
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Add()
    {
        ICollection<BookServiceModel> dbBooks = await this._bookService.GetAllBooksAsync();
        IEnumerable<BookViewModel> books = this._mapper.Map<IEnumerable<BookViewModel>>(dbBooks);
        
        return this.View(books);
    }
}
