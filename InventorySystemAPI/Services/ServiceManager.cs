using AutoMapper;
using InventorySystemAPI.Repositories.IRepositories;
using InventorySystemAPI.Services.IServices;

namespace InventorySystemAPI.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IItemService> _itemService;
    private readonly Lazy<IStatusService> _statusService;
    private readonly Lazy<ICategoryService> _categoryService;
    private readonly Lazy<IItemGroupService> _itemGroupService;
    
    public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _itemService = new Lazy<IItemService>(() => new ItemService(repositoryManager, mapper));
        _statusService = new Lazy<IStatusService>(() => new StatusService(repositoryManager, mapper));
        _categoryService = new Lazy<ICategoryService>(() => new CategoryService(repositoryManager, mapper));
        _itemGroupService = new Lazy<IItemGroupService>(() => new ItemGroupService(repositoryManager, mapper));
    }
    
    public IItemService ItemService => _itemService.Value;
    public IStatusService StatusService => _statusService.Value;
    public ICategoryService CategoryService => _categoryService.Value;
    public IItemGroupService ItemGroupService => _itemGroupService.Value;
}