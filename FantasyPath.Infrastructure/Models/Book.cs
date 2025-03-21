using System.ComponentModel.DataAnnotations;

namespace FantasyPath.Infrastructure.Models;

public class Book
{
    [Key] public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = null!;

    [Required]
    [MaxLength(100)]
    public string Author { get; set; } = null!;

    [Required]
    public string Isbn { get; set; } = null!;

    [MaxLength(500)] public string CoverImageUrl { get; set; } = null!;
    
    public virtual ICollection<UserBook> UserBooks { get; set; } = new HashSet<UserBook>();
    
    public virtual ICollection<Save> Saves { get; set; } = new HashSet<Save>();
}
