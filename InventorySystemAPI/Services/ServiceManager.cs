using AutoMapper;
using InventorySystemAPI.Repositories.IRepositories;
using InventorySystemAPI.Services.IServices;

namespace InventorySystemAPI.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IItemService> _itemService;
    private readonly Lazy<ICategoryService> _categoryService;
    private readonly Lazy<IItemGroupService> _itemGroupService;
    
    public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _itemService = new Lazy<IItemService>(() => new ItemService(repositoryManager, mapper));
        _categoryService = new Lazy<ICategoryService>(() => new CategoryService(repositoryManager, mapper));
    }
    
    public IItemService ItemService => _itemService.Value;
    public ICategoryService CategoryService => _categoryService.Value;
        _itemGroupService = new Lazy<IItemGroupService>(() => new ItemGroupService(repositoryManager, mapper));
    }
    
    public IItemService ItemService => _itemService.Value;
    public IItemGroupService ItemGroupService => _itemGroupService.Value;
}