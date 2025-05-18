using FantasyPath.Infrastructure.Models;

namespace FantasyPath.Services.Models;

public class SaveServiceModel
{
    public Guid Id { get; init; }
    
    public Guid BookId { get; init; }

    public int Skill { get; init; }

    public int Stamina { get; init; }

    public int Luck { get; init; }
    
    public ICollection<string> Inventory { get; set; } = new List<string>();
    
    public DateTime Created { get; init; } = DateTime.Now;
}
