using System.ComponentModel.DataAnnotations;

namespace FantasyPath.Infrastructure.Models;

public class Book
{
    [Key] public Guid Id { get; init; } = Guid.NewGuid();

    [Required]
    [MaxLength(100)]
    public string Title { get; init; } = null!;

    [Required]
    [MaxLength(100)]
    public string Author { get; init; } = null!;

    [Required]
    public string Isbn { get; init; } = null!;

    [Required] public int Order { get; init; }
}
