using InventorySystemAPI.Entities;
using InventorySystemAPI.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventorySystemAPI.Persistence;

namespace InventorySystemAPI.Repositories
{
    public class StatusRepository : RepositoryBase<Status>, IStatusRepository
    {
        public StatusRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
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

        public Task<IEnumerable<Status>> GetStatusesAsync()
        {
            var statuses = FindAll(trackChanges: false);

            return Task.FromResult(statuses.AsEnumerable());
        }
    }
}