using System.Collections.Generic;
using System.Linq;
using Ves.Domain.Enums;
using Ves.Domain.ValueObjects;

namespace Ves.Domain.Entities;

/// <summary>
/// Aggregate root representing an order. Contains invariants and business rules.
/// </summary>
public class Pedido
{
    private readonly List<PedidoDetalle> _detalles = new();

    public int Id { get; set; }
    public int ClienteId { get; set; }
    public DateTime Fecha { get; set; }
    public EstadoPedido Estado { get; private set; } = EstadoPedido.Pendiente;
    public Money Total { get; private set; }

    public IReadOnlyCollection<PedidoDetalle> Detalles => _detalles.AsReadOnly();

    public void AgregarItem(PedidoDetalle detalle)
    {
        _detalles.Add(detalle);
        RecalcularTotal();
    }

    public void Confirmar() => Estado = EstadoPedido.Confirmado;

    private void RecalcularTotal()
    {
        var currency = _detalles.FirstOrDefault()?.PrecioUnitario.Currency ?? "ARS";
        var total = _detalles.Sum(d => d.Subtotal().Amount);
        Total = new Money(total, currency);
    }
}
