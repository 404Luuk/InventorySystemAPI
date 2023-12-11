using InventorySystemAPI.Persistence;
using InventorySystemAPI.Repositories.IRepositories;

namespace InventorySystemAPI.Repositories;

public class RepositoryManager: IRepositoryManager
{
    private readonly Lazy<IItemRepository> _itemRepository;
    
    public RepositoryManager(ApplicationDbContext applicationDbContext)
    {
        _itemRepository = new Lazy<IItemRepository>(() => new ItemRepository(applicationDbContext)); // Add dbcontext to params
    }
    
    public IItemRepository ItemRepository => _itemRepository.Value;
    public Task SaveAsync()
    {
        throw new NotImplementedException();
    }
}