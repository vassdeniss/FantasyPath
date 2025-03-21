using FantasyPath.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FantasyPath.Web.Controllers;

public class CollectionController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return this.View(Enumerable.Empty<BookViewModel>());
    }
}
