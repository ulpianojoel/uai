using Ves.Domain.Entities;

namespace Ves.DAL.Interfaces;

public interface IUsuarioRepository
{
    Usuario? GetByEmail(string email);
    int Add(Usuario u);
}
