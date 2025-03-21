using FantasyPath.Services.Models;

namespace FantasyPath.Services.Contracts;

public interface IBookService
{
    Task<ICollection<BookServiceModel>> GetAllBooksAsync();
}
