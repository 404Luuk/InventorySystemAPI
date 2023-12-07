using InventorySystemAPI.Entities;
using InventorySystemAPI.Repositories.IRepositories;

namespace InventorySystemAPI.Repositories;

public class ItemRepository : IItemRepository
{
    public void CreateItem(Item item)
    {
        throw new NotImplementedException();
    }

    public void UpdateItem(Item item)
    {
        throw new NotImplementedException();
    }

    public void DeleteItem(Item item)
    {
        throw new NotImplementedException();
    }

    public Task<Item> GetItemAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Item>> GetItemsAsync()
    {
        throw new NotImplementedException();
    }
}