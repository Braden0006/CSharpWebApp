namespace CSharpWebAPI.Models;

using CSharpWebAPI.Models;
using Microsoft.EntityFrameworkCore;

public class UsersContext(DbContextOptions<UsersContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; } = null!;
}