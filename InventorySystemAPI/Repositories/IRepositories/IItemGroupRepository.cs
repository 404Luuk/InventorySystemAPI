using InventorySystemAPI.Entities;

namespace InventorySystemAPI.Repositories.IRepositories;

public interface IItemGroupRepository
{
    void CreateItemGroup(ItemGroup itemGroup);
    void UpdateItemGroup(ItemGroup itemGroup);
    void DeleteItemGroup(ItemGroup itemGroup);
    Task<ItemGroup> GetItemGroupAsync(int itemGroupId, bool trackChanges);
    Task<IEnumerable<ItemGroup>> GetItemGroupsAsync();
}