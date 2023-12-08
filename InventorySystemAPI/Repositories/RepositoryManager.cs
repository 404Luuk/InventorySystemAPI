using InventorySystemAPI.Repositories.IRepositories;

namespace InventorySystemAPI.Repositories;

public class RepositoryManager: IRepositoryManager
{
    private readonly Lazy<IItemRepository> _itemRepository;
    
    public RepositoryManager()
    {
        _itemRepository = new Lazy<IItemRepository>(() => new ItemRepository()); // Add dbcontext to params
    }
    
    public IItemRepository ItemRepository => _itemRepository.Value;
    public Task SaveAsync()
    {
        throw new NotImplementedException();
    }
}