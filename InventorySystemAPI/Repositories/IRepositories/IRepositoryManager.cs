namespace InventorySystemAPI.Repositories.IRepositories;

public interface IRepositoryManager
{
    IItemRepository ItemRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    IItemGroupRepository ItemGroupRepository { get; }
    Task SaveAsync();
}