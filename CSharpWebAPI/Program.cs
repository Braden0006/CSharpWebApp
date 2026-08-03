using Microsoft.EntityFrameworkCore;
using CSharpWebAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();

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

app.UseHttpsRedirection();

app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();