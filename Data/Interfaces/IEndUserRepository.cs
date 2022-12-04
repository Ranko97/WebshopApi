using Models;

namespace Data.Interfaces;

public interface IEndUserRepository
{
    Task<Enduser> Get(Guid id);

    Task<List<Enduser>> All();

    Task<Enduser> Login(string username, string password);

    Task<Enduser> Register(Enduser enduser);

    Task<Enduser> UpdateProfile(Enduser enduser);

    Task<Enduser> Verify(string verificationCode);

    Task<bool> UsernameExists(string username);
}