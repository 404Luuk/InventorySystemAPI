using InventorySystemAPI.Entities;
using InventorySystemAPI.Persistence;
using InventorySystemAPI.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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

    public async Task<Item> GetItemAsync(int itemId, bool trackChanges = false)
    {
        return await FindByCondition(o => o.Id.Equals(itemId), trackChanges)
            .Include<Item, Status>(item => item.Status)
            .Include<Item, ItemGroup>(item => item.ItemGroup)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException();
    }

    public async Task<IEnumerable<Item>> GetItemsAsync()
    {
        return await FindAll(trackChanges: false)
            .Include<Item, Status>(item => item.Status)
            .Include<Item, ItemGroup>(item => item.ItemGroup)
            .ToListAsync();
    }
}