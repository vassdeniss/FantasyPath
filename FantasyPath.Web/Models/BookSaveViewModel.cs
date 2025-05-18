namespace FantasyPath.Web.Models;

public class BookSaveViewModel
{
    public BookViewModel Book { get; init; } = null!;
    
    public ICollection<SaveViewModel> Saves { get; init; } = null!;
}
