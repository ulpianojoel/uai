using System;
using Ves.BLL.Interfaces;
using Ves.BLL.Utilities;
using Ves.DAL.Interfaces;
using Ves.Domain.Entities;

namespace Ves.BLL.Services;

/// <summary>
/// Service implementing authentication logic with hashed passwords.
/// </summary>
public class AuthService : IAuthService
{
    private readonly IUsuarioRepository _users;

    public AuthService(IUsuarioRepository users) => _users = users;

    public int Register(Usuario usuario, string password)
    {
        var (hash, salt) = PasswordHasher.HashPassword(password);
        usuario.PasswordHash = hash;
        usuario.PasswordSalt = salt;
        return _users.Add(usuario);
    }

    public AuthResult Login(string email, string password)
    {
        var stored = _users.GetByEmail(email);
        if (stored is null)
            return new AuthResult { Ok = false, Motivo = "Usuario inexistente" };
        if (!PasswordHasher.Verify(password, stored.PasswordHash, stored.PasswordSalt))
            return new AuthResult { Ok = false, Motivo = "Credenciales inválidas" };
        stored.UltimoLogin = DateTime.UtcNow;
        return new AuthResult { Ok = true, Token = Guid.NewGuid().ToString(), UsuarioId = stored.Id };
    }
}
