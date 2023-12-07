namespace InventorySystemAPI;

public static class ConfigureServices
{
    // make async when adding db
    public static IServiceCollection AddInventorySystemApi(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        return services;
    }
}