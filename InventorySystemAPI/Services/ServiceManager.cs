using AutoMapper;
using InventorySystemAPI.Repositories.IRepositories;
using InventorySystemAPI.Services.IServices;

namespace InventorySystemAPI.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IItemService> _itemService;
    private readonly Lazy<IStatusService> _statusService;
    
    public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _itemService = new Lazy<IItemService>(() => new ItemService(repositoryManager, mapper));
        _statusService = new Lazy<IStatusService>(() => new StatusService(repositoryManager, mapper));
    }
    
    public IItemService ItemService => _itemService.Value;
    public IStatusService StatusService => _statusService.Value;
}