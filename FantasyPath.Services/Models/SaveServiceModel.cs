using FantasyPath.Infrastructure.Models;

namespace FantasyPath.Services.Models;

public class SaveServiceModel
{
    public Guid Id { get; set; }
    
    public Guid BookId { get; set; }

    public int Skill { get; set; }

    public int Stamina { get; set; }

    public int Luck { get; set; }

    public ICollection<string> Inventory { get; set; } = new List<string>();
    
    public DateTime Created { get; set; } = DateTime.Now;
}
