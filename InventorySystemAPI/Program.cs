using InventorySystemAPI;

var builder = WebApplication.CreateBuilder(args);

await builder.Services.AddInventorySystemApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();



//TODO

// setup and add database
// create abstractions for repo and services
// Setup item object and create repo and service 
