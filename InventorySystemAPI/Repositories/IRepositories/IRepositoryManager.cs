namespace InventorySystemAPI.Repositories.IRepositories;

public interface IRepositoryManager
{
    IItemRepository ItemRepository { get; }
    IStatusRepository StatusRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    IItemGroupRepository ItemGroupRepository { get; }
    Task SaveAsync();
}