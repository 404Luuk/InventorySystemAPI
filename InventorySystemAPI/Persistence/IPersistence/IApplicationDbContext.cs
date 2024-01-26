using InventorySystemAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventorySystemAPI.Persistence.IPersistence;

public interface IApplicationDbContext
{ 
    DbSet<Item> Items { get; set; }
    DbSet<Status> Statuses { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}