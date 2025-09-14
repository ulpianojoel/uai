using Ves.Domain.ValueObjects;

namespace Ves.Domain.Entities;

/// <summary>
/// Product available for sale.
/// </summary>
public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public Money PrecioUnitario { get; set; }
    public Cantidad StockActual { get; set; }
    public bool Activo { get; set; }
}
