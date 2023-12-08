using InventorySystemAPI.Entities;

namespace InventorySystemAPI.Repositories.IRepositories;

public interface IItemRepository
{
    void CreateItem(Item item);
    void UpdateItem(Item item);
    void DeleteItem(Item item);
    Task<Item> GetItemAsync(Guid itemId, bool trackChanges);
    Task<IEnumerable<Item>> GetItemsAsync();
    
}