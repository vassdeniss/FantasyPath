using System.ComponentModel.DataAnnotations;

namespace FantasyPath.Infrastructure.Models;

public class Save
{
    [Key] public Guid Id { get; set; } = Guid.NewGuid();
    
    [Required] public Guid UserId { get; set; }
    
    [Required] public Guid BookId { get; set; }

    [Range(1, 12)]
    public int Skill { get; set; }

    [Range(1, 24)]
    public int Stamina { get; set; }

    [Range(1, 12)]
    public int Luck { get; set; }

    public string Inventory { get; set; } = "{}";

    public User User { get; set; } = null!;
    
    public Book Book { get; set; } = null!;
}
