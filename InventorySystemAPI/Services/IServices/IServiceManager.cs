namespace InventorySystemAPI.Services.IServices;

public interface IServiceManager
{
    IItemService ItemService { get; }
    IStatusService StatusService { get; }
}