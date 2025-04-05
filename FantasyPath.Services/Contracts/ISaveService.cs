using FantasyPath.Services.Models;

namespace FantasyPath.Services.Contracts;

public interface ISaveService
{
    Task<ICollection<SaveServiceModel>> GetBookByIdAndUserWithSavesAsync(Guid userId, Guid bookId);
    
    Task AddSaveToBookAndUserAsync(Guid bookId, Guid userId, int skill, int stamina, int luck);
    
    Task DeleteSaveAsync(Guid bookId);
}
