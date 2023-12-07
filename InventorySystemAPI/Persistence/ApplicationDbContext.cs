using InventorySystemAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventorySystemAPI.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public override async 
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
    
    public DbSet<Item> Items { get; set; }
    
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
}

//todo add migrations package 
//todo connect postgres docker to application