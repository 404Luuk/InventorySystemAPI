using InventorySystemAPI.Entities;
using InventorySystemAPI.Persistence;
using InventorySystemAPI.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace InventorySystemAPI.Repositories;

public class ItemGroupRepository : RepositoryBase<ItemGroup>, IItemGroupRepository
{
    public ItemGroupRepository(ApplicationDbContext repositoryContext) : base(repositoryContext)
    {
    }
    
    public void CreateItemGroup(ItemGroup itemGroup)
    {
        Create(itemGroup);
    }
    
    public void UpdateItemGroup(ItemGroup itemGroup)
    {
        Update(itemGroup);
    }
    
    public void DeleteItemGroup(ItemGroup itemGroup)
    {
        Delete(itemGroup);
    }

    public async Task<ItemGroup> GetItemGroupAsync(int itemGroupId, bool trackChanges = false)
    {
        return await FindByCondition(o => o.Id.Equals(itemGroupId), trackChanges)
            .Include<ItemGroup, Category>(itemGroup => itemGroup.Category)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException();
    }
    
    public async Task<IEnumerable<ItemGroup>> GetItemGroupsAsync()
    {
        var itemGroups = await FindAll(trackChanges: false)
            .Include<ItemGroup, Category>(itemGroup => itemGroup.Category)
            .ToListAsync();

        return itemGroups;
    }

}