using FantasyPath.Infrastructure.Common;
using FantasyPath.Infrastructure.Models;
using FantasyPath.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace FantasyPath.Services;

public class UserBookService(IRepository repository) : IUserBookService
{
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

    public async Task UpdateGraphByBookIdAndUserId(Guid bookId, Guid userId, string graphData)
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
}
