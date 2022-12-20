using Data.Interfaces;
using Data.Models;
using Models;

namespace Data.Repositories;

public class EndUserRepository : BaseRepository<Enduser>, IEndUserRepository
{
    public EndUserRepository(AppDbContext db, IConfiguration? configuration) : base(db, configuration)
    {
    }

    public Task<Enduser> Login(string username, string password)
    {
        throw new NotImplementedException();
    }

    public Task<Enduser> Register(Enduser enduser)
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