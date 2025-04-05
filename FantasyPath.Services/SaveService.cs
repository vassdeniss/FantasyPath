using AutoMapper;
using FantasyPath.Infrastructure.Common;
using FantasyPath.Infrastructure.Models;
using FantasyPath.Services.Contracts;
using FantasyPath.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace FantasyPath.Services;

public class SaveService(IRepository repo, IMapper mapper) : ISaveService
{
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

    public async Task DeleteSaveAsync(Guid bookId)
    {
        await repo.DeleteAsync<Save>(bookId);
    }
}
