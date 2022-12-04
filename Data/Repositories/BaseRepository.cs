using Data.Models;

namespace Data.Repositories;

public class BaseRepository
{
    protected AppDbContext db;

    protected IConfiguration? configuration;

    public BaseRepository(AppDbContext db, IConfiguration? configuration)
    {
        this.db = db;
        this.configuration = configuration;
    }
}