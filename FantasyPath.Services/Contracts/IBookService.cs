using FantasyPath.Services.Models;

namespace FantasyPath.Services.Contracts;

public interface IBookService
{
    Task<ICollection<BookServiceModel>> GetAllBooksUserDoesNotOwnAsync(Guid userId);
    
    Task<ICollection<BookServiceModel>> GetAllBooksForUserAsync(Guid userId);
    
    Task AddBookToUserAsync(Guid userId, Guid bookId);
}
