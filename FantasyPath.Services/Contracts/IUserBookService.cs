using FantasyPath.Services.Models;

namespace FantasyPath.Services.Contracts;

public interface IUserBookService
{
    Task<ICollection<BookServiceModel>> GetAllBooksForUserAsync(Guid userId);
    Task<string?> GetGraphByBookIdAndUserId(Guid bookId, Guid userId);    
    Task UpdateGraphByBookIdAndUserId(Guid bookId, Guid userId, string? graphData);
    Task UpdateLastViewedTime(Guid bookId, Guid userId);
    Task AddBookToUserAsync(Guid userId, Guid bookId);
}
