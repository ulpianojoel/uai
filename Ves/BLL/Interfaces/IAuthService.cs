using Ves.Domain.Entities;

namespace Ves.BLL.Interfaces;

public interface IAuthService
{
    AuthResult Login(string email, string password);
    int Register(Usuario usuario, string password);
}
