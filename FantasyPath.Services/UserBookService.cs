using AutoMapper;
using FantasyPath.Infrastructure.Common;
using FantasyPath.Infrastructure.Models;
using FantasyPath.Services.Contracts;
using FantasyPath.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace FantasyPath.Services;

public class UserBookService(IRepository repository, IMapper mapper) : IUserBookService
{
    public async Task<ICollection<BookServiceModel>> GetAllBooksForUserAsync(Guid userId)
    {
        List<Book> userBooks = await repository.AllReadonly<UserBook>(ub => ub.UserId == userId)
            .OrderByDescending(b => b.LastViewed)
            .Select(ub => ub.Book)
            .ToListAsync();
        return mapper.Map<ICollection<BookServiceModel>>(userBooks);
    }
    
    public async Task<ICollection<BookServiceModel>> GetAllBooksUserDoesNotOwnAsync(Guid userId)
    {
        List<Guid> userBookIds = await repository.AllReadonly<UserBook>(ub => ub.UserId == userId)
            .Select(ub => ub.BookId)
            .ToListAsync();

        List<Book> books = await repository.AllReadonly<Book>(b => !userBookIds.Contains(b.Id))
            .ToListAsync();

        return mapper.Map<ICollection<BookServiceModel>>(books);
    }
    
    public async Task<string?> GetGraphByBookIdAndUserId(Guid bookId, Guid userId)
    {
        UserBook? userBook = await repository.AllReadonly<UserBook>()
            .Where(ub => ub.BookId == bookId && ub.UserId == userId)
            .FirstOrDefaultAsync();

        if (userBook == null)
        {
            throw new InvalidOperationException("UserBook not found");
        }
        
        return userBook.GraphData;
    }

    public async Task UpdateGraphByBookIdAndUserId(Guid bookId, Guid userId, string? graphData)
    {
        UserBook? userBook = await repository.All<UserBook>()
            .Where(ub => ub.BookId == bookId && ub.UserId == userId)
            .FirstOrDefaultAsync();

        if (userBook == null)
        {
            throw new InvalidOperationException("UserBook not found");
        }
        
        userBook.GraphData = graphData;
        
        await repository.SaveChangesAsync();
    }

    public async Task UpdateLastViewedTime(Guid bookId, Guid userId)
    {
        UserBook? userBook = await repository.All<UserBook>()
            .Where(ub => ub.BookId == bookId && ub.UserId == userId)
            .FirstOrDefaultAsync();

        if (userBook == null)
        {
            throw new InvalidOperationException("UserBook not found");
        }
        
        userBook.LastViewed = DateTime.Now;
        
        await repository.SaveChangesAsync();
    }
    
    public async Task AddBookToUserAsync(Guid userId, Guid bookId)
    {
        User? user = await repository.AllReadonly<User>(u => u.Id == userId)
            .FirstOrDefaultAsync();
        if (user == null)
        {
            throw new ArgumentException("User not found");
        }
        
        Book? book = await repository.AllReadonly<Book>(b => b.Id == bookId)
            .FirstOrDefaultAsync();
        if (book == null)
        {
            throw new ArgumentException("Book not found");
        }
        
        bool alreadyExists = await repository.All<UserBook>(ub => ub.UserId == userId && ub.BookId == bookId)
            .AnyAsync();
        if (!alreadyExists)
        {
            UserBook userBook = new()
            {
                UserId = userId,
                BookId = bookId
            };

            await repository.AddAsync(userBook);
            await repository.SaveChangesAsync();
        }
    }
}
