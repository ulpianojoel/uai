using Ves.Domain.ValueObjects;

namespace Ves.Domain.Entities;

/// <summary>
/// Line item within a purchase order.
/// </summary>
public class PedidoDetalle
{
    public int Id { get; set; }
    public int PedidoId { get; set; }
    public int ProductoId { get; set; }
    public Cantidad Cantidad { get; set; }
    public Money PrecioUnitario { get; set; }

    public Money Subtotal() => new(Cantidad.Value * PrecioUnitario.Amount, PrecioUnitario.Currency);
}
