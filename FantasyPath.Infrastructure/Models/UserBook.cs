using System.ComponentModel.DataAnnotations;

namespace FantasyPath.Infrastructure.Models;

public class UserBook
{
    [Required] public Guid UserId { get; init; }
    
    [Required] public Guid BookId { get; init; }

    public string GraphData { get; set; } = "";
    
    public User User { get; init; } = null!;

    public Book Book { get; init; } = null!;
}
