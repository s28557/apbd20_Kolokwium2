using Kol2.Data;
using Kol2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kol2.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;
    public DbService(DatabaseContext context)
    {
        _context = context;
    }


    public async Task<ICollection<Character>> GetCharacterData(int itemId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DoesCharacterExist(int characterId)
    {
        return await _context.Characters.AnyAsync(e => e.Id == characterId);
    }

    public async Task<ICollection<Character>> GetItemData(int itemId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DoesItemExist(int itemId)
    {
        return await _context.Items.AnyAsync(e => e.Id == itemId);
    }

    public Task AddItemBackpack(IEnumerable<Backpack> backpacks)
    {
        throw new NotImplementedException();
    }
    
    public async Task AddNewItem(Item item)
    {
        await _context.AddAsync(item);
        await _context.SaveChangesAsync();
    }
}