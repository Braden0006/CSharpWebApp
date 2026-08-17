using CSharpWebAPI.Components;
using Microsoft.EntityFrameworkCore;
using CSharpWebAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Adds services for Razor pages / MVC
builder.Services.AddControllersWithViews();

// This is for Blazor server interactivity
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

// Adds the database context to the DI container and specifies that it will use 
// an in-memory database. 
builder.Services.AddDbContext<UsersContext>(opt =>
    opt.UseInMemoryDatabase("Users"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Required for interactive components since .NET 8
app.UseAntiforgery();

app.MapStaticAssets();

app.UseHttpsRedirection();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.MapControllers();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();