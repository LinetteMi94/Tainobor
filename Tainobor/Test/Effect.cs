using System;

namespace Tainobor.Test;

/// <summary>
/// Представляет эффект, который изменяет определённое значение на указанное количество.
/// </summary>
public class Effect
{
    public required Enum Name;
    public int Value { get; init; }
}