namespace InventorySystemAPI.Services.IServices;

public interface IServiceManager
{
    IItemService ItemService { get; }
    ICategoryService CategoryService { get; }
    IItemGroupService ItemGroupService { get; }
}