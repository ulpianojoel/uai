using Ves.Domain.ValueObjects;

namespace Ves.Domain.Entities;

/// <summary>
/// Aggregate root representing a customer in the system.
/// </summary>
public class Cliente
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool Activo { get; set; }
    public DateTime FechaAlta { get; set; }
}
