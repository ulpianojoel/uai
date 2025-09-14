namespace Ves.Domain.Entities;

/// <summary>
/// Result object returned by authentication attempts.
/// </summary>
public class AuthResult
{
    public bool Ok { get; set; }
    public string? Token { get; set; }
    public string? Motivo { get; set; }
    public int? UsuarioId { get; set; }
}
