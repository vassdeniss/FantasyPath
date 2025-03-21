using AutoMapper;
using FantasyPath.Infrastructure.Common;
using FantasyPath.Infrastructure.Models;
using FantasyPath.Services.Contracts;
using FantasyPath.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace FantasyPath.Services;

public class BookService(IRepository repo, IMapper mapper) : IBookService
{
    public async Task<ICollection<BookServiceModel>> GetAllBooksAsync()
    {
        List<Book> books = await repo.AllReadonly<Book>().ToListAsync();
        return mapper.Map<ICollection<BookServiceModel>>(books);
    }
}
