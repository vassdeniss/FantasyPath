using System.ComponentModel.DataAnnotations;

namespace FantasyPath.Infrastructure.Models;

public class PassageEntry
{
    [Key] public Guid Id { get; set; } = Guid.NewGuid();
    
    [Required] public Guid UserId { get; set; }
    
    [Required] public Guid BookId { get; set; }

    [Range(1, 500)]
    public int SectionNumber { get; set; }

    [Range(0, 500)]
    public int? PreviousSectionNumber { get; set; }
    
    public ICollection<int> NextSectionNumbers { get; set; } = new HashSet<int>();

    public string Details { get; set; } = "{}";

    public User User { get; set; } = null!;
    
    public Book Book { get; set; } = null!;
}
