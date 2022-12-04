using Data.Interfaces;
using Data.Models;
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
        return await Task.FromResult(
            new[] {
                new Enduser {
                    Id = new Guid("90e93b46-8516-4149-963f-6571ca6fdd2f"),
                    FirstName = "Marko",
                    LastName = "Markovic",
                    UserName = "marko",
                    IsActive = true,
                },
                new Enduser {
                    Id = new Guid("f76f75e0-47b7-4813-9856-20c2d1bebaa7"),
                    FirstName = "Petar",
                    LastName = "Petrovic",
                    UserName = "petar",
                    IsActive = true,
                },
            }.ToList()
        );
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