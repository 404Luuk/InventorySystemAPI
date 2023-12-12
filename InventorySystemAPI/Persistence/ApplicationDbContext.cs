using System.Reflection;
using InventorySystemAPI.Entities;
using InventorySystemAPI.Persistence.IPersistence;
using Microsoft.EntityFrameworkCore;

namespace InventorySystemAPI.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
    
    public DbSet<Item> Items { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        modelBuilder.Entity<Item>().Property(item => item.Id).ValueGeneratedOnAdd();

        base.OnModelCreating(modelBuilder);
    }
}

//todo add migrations package 
//todo connect postgres docker to application