namespace FantasyPath.Services.Models;

public class BookServiceModel
{
    public Guid Id { get; set; }
    
    public string Title { get; set; } = null!;
    
    public string Author { get; set; } = null!;
    
    public string Isbn { get; set; } = null!;

    public string CoverImageUrl { get; set; } = null!;
}
