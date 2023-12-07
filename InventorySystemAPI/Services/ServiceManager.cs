using InventorySystemAPI.Services.IServices;

namespace InventorySystemAPI.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IItemService> _itemService;
    
    public ServiceManager(IItemService itemService)
    {
        _itemService = new Lazy<IItemService>(() => new ItemService()); // Add repomanager to params
    }
    
    public IItemService ItemService => _itemService.Value;
}