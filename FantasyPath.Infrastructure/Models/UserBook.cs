using System.ComponentModel.DataAnnotations;

namespace FantasyPath.Infrastructure.Models;

public class UserBook
{
    [Required] public Guid UserId { get; set; }
    
    [Required] public Guid BookId { get; set; }
    
    public User User { get; set; } = null!;

    public Book Book { get; set; } = null!;
}
