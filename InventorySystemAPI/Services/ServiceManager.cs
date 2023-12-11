using AutoMapper;
using InventorySystemAPI.Repositories.IRepositories;
using InventorySystemAPI.Services.IServices;

namespace InventorySystemAPI.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IItemService> _itemService;
    
    public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _itemService = new Lazy<IItemService>(() => new ItemService(repositoryManager, mapper));
    }
    
    public IItemService ItemService => _itemService.Value;
}