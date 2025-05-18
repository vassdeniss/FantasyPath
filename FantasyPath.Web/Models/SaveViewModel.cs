namespace FantasyPath.Web.Models;

public class SaveViewModel
{
    public Guid Id { get; init; }
    
    public Guid BookId { get; init; }

    public int Skill { get; init; }

    public int Stamina { get; init; }

    public int Luck { get; init; }
    
    public string GraphData { get; init; }

    public ICollection<string> Inventory { get; init; } = new List<string>();
    
    public DateTime Created { get; init; } = DateTime.Now;
}
