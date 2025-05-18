using System.ComponentModel.DataAnnotations;

namespace FantasyPath.Infrastructure.Models;

public class Save
{
    [Key] public Guid Id { get; init; } = Guid.NewGuid();
    
    [Required] public Guid UserId { get; init; }
    
    [Required] public Guid BookId { get; init; }
    
    [Range(1, 12)]
    public int Skill { get; set; }

    [Range(1, 24)]
    public int Stamina { get; set; }

    [Range(1, 12)]
    public int Luck { get; set; }

    [Required] public ICollection<string> Inventory { get; set; } = new List<string>();
    
    [Required] public DateTime Created { get; init; } = DateTime.Now;

    public User User { get; init; } = null!;
    
    public Book Book { get; init; } = null!;
}
