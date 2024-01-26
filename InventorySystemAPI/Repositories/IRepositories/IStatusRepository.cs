using InventorySystemAPI.Entities;

namespace InventorySystemAPI.Repositories.IRepositories;

public interface IStatusRepository
{
    void CreateStatus(Status status);
    void UpdateStatus(Status status);
    void DeleteStatus(Status status);
    Task<Status> GetStatusAsync(int statusId, bool trackChanges);
    Task<IEnumerable<Status>> GetStatusesAsync();
    
}