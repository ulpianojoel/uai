namespace Ves.Domain.ValueObjects;

/// <summary>
/// Value object representing a monetary amount in a specific currency.
/// </summary>
public readonly record struct Money(decimal Amount, string Currency)
{
    public override string ToString() => $"{Amount} {Currency}";
}
