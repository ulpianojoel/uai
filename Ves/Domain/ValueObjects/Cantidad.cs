namespace Ves.Domain.ValueObjects;

/// <summary>
/// Represents a quantity of items. Encapsulates domain invariants like non-negative values.
/// </summary>
public readonly record struct Cantidad(int Value)
{
    public override string ToString() => Value.ToString();
}
