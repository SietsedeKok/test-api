using Application.Interfaces;
using Application.Services;
using Host.Endpoints;
using Infrastructure.Interfaces;
using Infrastructure.Repositories;

// Builder

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddScoped<IItemService, ItemService>();

// Config
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin();
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
    });
});

var app = builder.Build();

// App
app.UseCors();

// Base Endpoints
app.MapGet("/health", () => "Healthy!");

app.MapGet("/items", async (IItemService itemService) => 
    await itemService.GetItems());

app.MapGet("/items/{id:int}", async (int id, IItemService itemService) => 
    await itemService.GetItem(id));

CookingEndpoints.AddCookingEndpoints(app);

app.Run();
