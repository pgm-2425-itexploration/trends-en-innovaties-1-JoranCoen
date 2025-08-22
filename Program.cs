using blazor_tutorial.Components;
using Data;
using MongoDB.Driver;
using Repositories;
using Repositories.IRepositories;
using Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddSingleton<IMongoClient>(sp =>
{
    var config = sp.GetRequiredService<IConfiguration>();
    var connectionString =
        config.GetValue<string>("MONGO_CONNECTION_STRING")
        ?? Environment.GetEnvironmentVariable("MONGO_CONNECTION_STRING")
        ?? throw new InvalidOperationException("Mongo connection string is missing.");
    return new MongoClient(connectionString);
});
builder.Services.AddSingleton<MongoDbContext>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ProductService>();

var app = builder.Build();

// Seed the database.
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        await Data.SeedData.InitializeAsync(services);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred seeding the DB.");
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
