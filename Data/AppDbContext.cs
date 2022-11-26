using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Models;

public class AppDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public AppDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
    }

    public DbSet<Category>? Categories { get; set; }
    public DbSet<Enduser>? Endusers { get; set; }
    public DbSet<Product>? Products { get; set; }
}