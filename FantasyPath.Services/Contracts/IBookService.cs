using FantasyPath.Services.Models;

namespace FantasyPath.Services.Contracts;

public interface IBookService
{
    Task<ICollection<BookServiceModel>> GetAllBooksAsync();
    
    Task<BookServiceModel> GetBookByIdAsync(Guid bookId);
}
