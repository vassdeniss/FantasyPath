using FantasyPath.Services.Contracts;
using FantasyPath.Web.Extensions;
using FantasyPath.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FantasyPath.Web.Controllers;

public class SaveController(ISaveService saveService) : Controller
{
    [HttpGet]
    [Authorize]
    public IActionResult Add(Guid id)
    {
        if (id == Guid.Empty)
        {
            return this.BadRequest("Invalid book ID.");
        }

        SaveViewModel save = new()
        {
            BookId = id
        };

        return this.View(save);
    }
    
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Add(SaveViewModel model)
    {
        if (!this.ModelState.IsValid)
        {
            return this.View(model);
        }

        await saveService.AddSaveToBookAndUserAsync(model.BookId, this.User.Id(),
            model.Skill, model.Stamina, model.Luck);
        
        return this.RedirectToAction("Index", "Book", new { id = model.BookId });
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Delete(Guid bookId, Guid saveId)
    {
        await saveService.DeleteSaveAsync(saveId);
        return this.RedirectToAction("Index", "Book", new { id = bookId   });
    }
}