using AutoMapper;
using FantasyPath.Infrastructure.Common;
using FantasyPath.Infrastructure.Models;
using FantasyPath.Services.Contracts;
using FantasyPath.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace FantasyPath.Services;

public class BookService(IRepository repository, IMapper mapper) : IBookService
{
    public async Task<ICollection<BookServiceModel>> GetAllBooksAsync()
    {
        ICollection<Book> books = await repository.AllReadonly<Book>().ToListAsync();
        return mapper.Map<ICollection<BookServiceModel>>(books);
    }

    public async Task<BookServiceModel> GetBookByIdAsync(Guid bookId)
    {
        Book book = await repository.GetByIdAsync<Book>(bookId);
        return mapper.Map<BookServiceModel>(book);
    }
}
