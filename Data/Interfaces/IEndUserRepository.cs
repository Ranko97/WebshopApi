using Models;

namespace Data.Interfaces;

public interface IEndUserRepository : IBaseRepository<Enduser>
{
    Task<Enduser> Login(string username, string password);

    Task<Enduser> Register(Enduser enduser);

    Task<Enduser> Verify(string verificationCode);

    Task<bool> UsernameExists(string username);
}