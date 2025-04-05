namespace FantasyPath.Web.Models;

public class BookSaveViewModel
{
    public BookViewModel Book { get; set; }
    
    public ICollection<SaveViewModel> Saves { get; set; }
}
