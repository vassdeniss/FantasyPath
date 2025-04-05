using AutoMapper;
using FantasyPath.Infrastructure.Common;
using FantasyPath.Infrastructure.Models;
using FantasyPath.Services.Contracts;
using FantasyPath.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace FantasyPath.Services;

public class BookService(IRepository repo, IMapper mapper) : IBookService
{
    public async Task<ICollection<BookServiceModel>> GetAllBooksUserDoesNotOwnAsync(Guid userId)
    {
        List<Guid> userBookIds = await repo.AllReadonly<UserBook>(ub => ub.UserId == userId)
            .Select(ub => ub.BookId)
            .ToListAsync();

        List<Book> books = await repo.AllReadonly<Book>(b => !userBookIds.Contains(b.Id))
            .ToListAsync();

        return mapper.Map<ICollection<BookServiceModel>>(books);
    }

    public async Task<ICollection<BookServiceModel>> GetAllBooksForUserAsync(Guid userId)
    {
        List<Book> userBooks = await repo.AllReadonly<UserBook>(ub => ub.UserId == userId)
            .Select(ub => ub.Book)
            .ToListAsync();
        return mapper.Map<ICollection<BookServiceModel>>(userBooks);
    }

    public async Task<BookServiceModel> GetBookByIdAsync(Guid bookId)
    {
        Book book = await repo.GetByIdAsync<Book>(bookId);
        return mapper.Map<BookServiceModel>(book);
    }

    public async Task AddBookToUserAsync(Guid userId, Guid bookId)
    {
        User? user = await repo.AllReadonly<User>(u => u.Id == userId)
            .FirstOrDefaultAsync();
        if (user == null)
        {
            throw new ArgumentException("User not found");
        }
        
        Book? book = await repo.AllReadonly<Book>(b => b.Id == bookId)
            .FirstOrDefaultAsync();
        if (book == null)
        {
            throw new ArgumentException("Book not found");
        }
        
        bool alreadyExists = await repo.All<UserBook>(ub => ub.UserId == userId && ub.BookId == bookId)
            .AnyAsync();
        if (!alreadyExists)
        {
            UserBook userBook = new()
            {
                UserId = userId,
                BookId = bookId
            };

            await repo.AddAsync(userBook);
            await repo.SaveChangesAsync();
        }
    }
}
