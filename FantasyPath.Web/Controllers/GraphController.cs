using FantasyPath.Services.Contracts;
using FantasyPath.Web.Extensions;
using FantasyPath.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace FantasyPath.Web.Controllers;

public class GraphController(IUserBookService userBookService) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index(Guid bookId, string bookName)
    {
        Guid userId = this.User.Id();
        string? graphData = await userBookService.GetGraphByBookIdAndUserId(bookId, userId);
        
        GraphViewModel model = new() { BookId = bookId, BookName = bookName, GraphData = graphData };
        return this.View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Save(GraphViewModel graphViewModel)
    {
        Guid userId = this.User.Id();
        await userBookService.UpdateGraphByBookIdAndUserId(graphViewModel.BookId, userId, graphViewModel.GraphData);
        return this.RedirectToAction("Index", new { bookId = graphViewModel.BookId, bookName = graphViewModel.BookName });
    }
}
