using InventorySystemAPI.Persistence;
using InventorySystemAPI.Repositories.IRepositories;

namespace InventorySystemAPI.Repositories;

public class RepositoryManager: IRepositoryManager
{ 
    private readonly Lazy<IItemRepository> _itemRepository;
    private readonly ApplicationDbContext? _repositoryContext;
    
    public RepositoryManager(ApplicationDbContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _itemRepository = new Lazy<IItemRepository>(() => new ItemRepository(repositoryContext)); // Add dbcontext to params
    }
    
    public IItemRepository ItemRepository => _itemRepository.Value;
    public async Task SaveAsync()
    {
        await _repositoryContext!.SaveChangesAsync();
    }
}