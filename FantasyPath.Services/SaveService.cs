using AutoMapper;
using FantasyPath.Infrastructure.Common;
using FantasyPath.Infrastructure.Models;
using FantasyPath.Services.Contracts;
using FantasyPath.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace FantasyPath.Services;

public class SaveService(IRepository repo, IMapper mapper) : ISaveService
{
    public async Task<SaveServiceModel> GetSaveByIdAsync(Guid id)
    {
        Save save = await repo.GetByIdAsync<Save>(id);
        return mapper.Map<SaveServiceModel>(save);
    }

    public async Task<ICollection<SaveServiceModel>> GetBookByIdAndUserWithSavesAsync(Guid userId, Guid bookId)
    {
        List<Save> saves = await repo.AllReadonly<Save>(s => s.UserId == userId && s.BookId == bookId)
            .Include(s => s.Book)
            .ToListAsync();

        return mapper.Map<ICollection<SaveServiceModel>>(saves);
    }

    public async Task AddSaveToBookAndUserAsync(Guid bookId, Guid userId,
        int skill, int stamina, int luck)
    {
        Save save = new()
        {
            UserId = userId,
            BookId = bookId,
            Skill = skill,
            Stamina = stamina,
            Luck = luck
        };

        await repo.AddAsync(save);
        await repo.SaveChangesAsync();
    }

    public async Task UpdateSaveAsync(Guid id, int skill, int stamina, int luck, ICollection<string> inventory)
    {
        Save save = await repo.GetByIdAsync<Save>(id);
        
        save.Skill = skill;
        save.Stamina = stamina;
        save.Luck = luck;
        save.Inventory = inventory;
        
        await repo.SaveChangesAsync();
    }

    public async Task DeleteSaveAsync(Guid bookId)
    {
        await repo.DeleteAsync<Save>(bookId);
        await repo.SaveChangesAsync();
    }
}
