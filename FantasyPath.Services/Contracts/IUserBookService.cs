namespace FantasyPath.Services.Contracts;

public interface IUserBookService
{
    Task<string?> GetGraphByBookIdAndUserId(Guid bookId, Guid userId);    
    Task UpdateGraphByBookIdAndUserId(Guid bookId, Guid userId, string? graphData);    
}
