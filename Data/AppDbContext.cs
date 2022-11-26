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

    // protected override void OnConfiguring(DbContextOptionsBuilder options)
    // {
    //     // connect to postgres with connection string from app settings
    // }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to postgres with connection string from app settings

        // options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));

        options.UseNpgsql("User ID =postgres;Password=ne dam;Server=localhost;Port=5432;Database=webshop; Integrated Security=true;Pooling=true;");
    }

    public DbSet<Category>? Categories { get; set; }
    public DbSet<Enduser>? Endusers { get; set; }
    public DbSet<Product>? Products { get; set; }
}