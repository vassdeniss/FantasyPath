namespace FantasyPath.Web.Models;

public class GraphViewModel
{
    public Guid BookId { get; init; }

    public string BookName { get; init; } = null!;

    public string? GraphData { get; init; }
}
