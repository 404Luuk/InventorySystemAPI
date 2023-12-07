namespace InventorySystemAPI.Repositories.IRepositories;

public interface IRepositoryManager
{
    IItemRepository ItemRepository { get; }
    Task SaveAsync();
}