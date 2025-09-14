using System;
namespace Ves.Domain.Entities;

/// <summary>
/// User entity used for authentication. Stores password hash and salt.
/// </summary>
public class Usuario
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public byte[] PasswordHash { get; set; } = Array.Empty<byte>();
    public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();
    public bool Activo { get; set; }
    public DateTime? UltimoLogin { get; set; }
}
