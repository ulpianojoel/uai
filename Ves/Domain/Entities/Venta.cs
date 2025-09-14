using System;
using Ves.Domain.ValueObjects;

namespace Ves.Domain.Entities;

/// <summary>
/// Represents a sales transaction for reporting.
/// </summary>
public class Venta
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public int ClienteId { get; set; }
    public Money Total { get; set; }
}
