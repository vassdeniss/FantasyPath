namespace FantasyPath.Services.Models;

public class BookServiceModel
{
    public Guid Id { get; init; }
    
    public string Title { get; init; } = null!;
    
    public string Author { get; init; } = null!;
    
    public string Isbn { get; init; } = null!;

    public string CoverImageUrl { get; init; } = null!;
}
