namespace FantasyPath.Web.Models;

public class BookViewModel
{
    public Guid Id { get; init; }
        
    public string Title { get; init; } = null!;
        
    public string Author { get; init; } = null!;
        
    public string Isbn { get; init; } = null!;
        
    public string CoverImageUrl { get; init; } = null!;

    public ICollection<SaveViewModel> Saves { get; init; } = new List<SaveViewModel>();
}
