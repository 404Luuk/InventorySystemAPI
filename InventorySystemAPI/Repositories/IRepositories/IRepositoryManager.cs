namespace InventorySystemAPI.Repositories.IRepositories;

public interface IRepositoryManager
{
    IItemRepository ItemRepository { get; }
    IItemGroupRepository ItemGroupRepository { get; }
    Task SaveAsync();
}