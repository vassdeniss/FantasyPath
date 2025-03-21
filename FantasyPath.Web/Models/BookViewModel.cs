namespace FantasyPath.Web.Models;

public class BookViewModel
{
    public Guid Id { get; set; }
        
    public string Title { get; set; } = null!;
        
    public string Author { get; set; } = null!;
        
    public string Isbn { get; set; } = null!;
        
    public string CoverImageUrl { get; set; } = null!;
}
