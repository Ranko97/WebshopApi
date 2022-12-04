using Data.Interfaces;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Repositories;

public class EndUserRepository : BaseRepository, IEndUserRepository
{
    public EndUserRepository(AppDbContext db, IConfiguration? configuration) : base(db, configuration)
    {
    }

    public Task<Enduser> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Enduser>> All()
    {
        return await db.Endusers.OrderByDescending(x => x.Created).ToListAsync();
    }

    public Task<Enduser> Login(string username, string password)
    {
        throw new NotImplementedException();
    }

    public Task<Enduser> Register(Enduser enduser)
    {
        throw new NotImplementedException();
    }

    public Task<Enduser> UpdateProfile(Enduser enduser)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UsernameExists(string username)
    {
        throw new NotImplementedException();
    }

    public Task<Enduser> Verify(string verificationCode)
    {
        throw new NotImplementedException();
    }
}