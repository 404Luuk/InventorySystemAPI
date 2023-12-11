using InventorySystemAPI.Entities;
using InventorySystemAPI.Persistence;
using InventorySystemAPI.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace InventorySystemAPI.Repositories;

public class ItemRepository : RepositoryBase<Item>, IItemRepository
{
    public ItemRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }
    
    public void CreateItem(Item item)
    { 
        Create(item);
    }

    public void UpdateItem(Item item)
    {
        Update(item);
    }

    public void DeleteItem(Item item)
    {
        Delete(item);
    }

    public async Task<Item> GetItemAsync(Guid itemId, bool trackChanges = false)
    => await FindByCondition(o => o.Id.Equals(itemId), trackChanges).FirstOrDefaultAsync() ?? throw new InvalidOperationException();

    public Task<IEnumerable<Item>> GetItemsAsync()
    {
        var items = FindAll(trackChanges: false);
        
        return Task.FromResult(items.AsEnumerable());
    }


}