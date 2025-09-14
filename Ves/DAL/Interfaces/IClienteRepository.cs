using Ves.Domain.Entities;

namespace Ves.DAL.Interfaces;

/// <summary>
/// Repository pattern for managing <see cref="Cliente"/> entities.
/// </summary>
public interface IClienteRepository
{
    int Add(Cliente c);
}
