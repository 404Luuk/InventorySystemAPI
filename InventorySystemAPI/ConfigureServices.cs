using InventorySystemAPI.Persistence;
using InventorySystemAPI.Persistence.IPersistence;
using InventorySystemAPI.Repositories;
using InventorySystemAPI.Repositories.IRepositories;
using InventorySystemAPI.Services;
using InventorySystemAPI.Services.IServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Npgsql;

namespace InventorySystemAPI;

public static class ConfigureServices
{
    private static readonly IConfiguration Configuration;
    
    // make async when adding db
    public static async Task<IServiceCollection> AddInventorySystemApi(this IServiceCollection services)
    {
        var dataSourceBuilder = 
            new NpgsqlDataSourceBuilder("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=mysecretpass;Include Error Detail=true");
        var connectionString = dataSourceBuilder.ConnectionString;

        if (string.IsNullOrEmpty(connectionString))
        {
            Console.WriteLine(connectionString);
        }

        await using var dataSource = dataSourceBuilder.Build();

        services.AddDbContext<ApplicationDbContext>(options
            => options.UseNpgsql(connectionString,
                builder =>
                {
                    builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName);
                }));

        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
        
        services.AddScoped<IServiceManager, ServiceManager>();
        services.AddScoped<IRepositoryManager, RepositoryManager>();
        services.AddScoped<IItemRepository, ItemRepository>();
        services.AddScoped<IItemService, ItemService>();
        
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        return services;
    }
}