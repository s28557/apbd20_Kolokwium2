using Kol2.Models;
namespace Kol2.Services;

public interface IDbService
{
    Task<ICollection<Character>> GetCharacterData(int itemId);
    Task<bool> DoesCharacterExist(int characterId);
    Task<ICollection<Character>> GetItemData(int itemId);
    Task<bool> DoesItemExist(int itemId);
    
    Task AddItemBackpack(IEnumerable<Backpack> backpacks);
    Task AddNewItem(Item item);
    
}