namespace InventorySystemAPI.Repositories.IRepositories;

public interface IRepositoryManager
{
    IItemRepository ItemRepository { get; }
    IStatusRepository StatusRepository { get; }
    Task SaveAsync();
}