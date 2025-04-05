using FantasyPath.Services.Models;

namespace FantasyPath.Services.Contracts;

public interface ISaveService
{
    Task<SaveServiceModel> GetSaveByIdAsync(Guid id);
    
    Task<ICollection<SaveServiceModel>> GetBookByIdAndUserWithSavesAsync(Guid userId, Guid bookId);
    
    Task AddSaveToBookAndUserAsync(Guid bookId, Guid userId, int skill, int stamina, int luck);
    
    Task UpdateSaveAsync(Guid id, int skill, int stamina, int luck, ICollection<string> inventory);
    
    Task DeleteSaveAsync(Guid bookId);
}
