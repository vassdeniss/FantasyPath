namespace FantasyPath.Web.Models;

public class BookSaveViewModel
{
    public BookViewModel Book { get; set; } = null!;
    
    public ICollection<SaveViewModel> Saves { get; set; } = null!;
}
