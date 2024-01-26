using InventorySystemAPI.Entities;
using InventorySystemAPI.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace InventorySystemAPI.Repositories;

public class StatusRepository : RepositoryBase<Status>, IStatusRepository
{
    public StatusRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
    
    public void CreateStatus(Status status)
    {
        Create(status);
    }
    
    public void UpdateStatus(Status status)
    {
        Update(status);
    }
    
    public void DeleteStatus(Status status)
    {
        Delete(status);
    }

    public async Task<Status> GetStatusAsync(int statusId, bool trackChanges = false)
    {
        return await FindByCondition(o => o.Id.Equals(statusId), trackChanges)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException();
    }
    
    public async Task<IEnumerable<Status>> GetStatusesAsync(bool trackChanges = false)
    {
        var statuses = await FindAll(trackChanges: false)
            .ToListAsync();
        
        return statuses;
    }
}