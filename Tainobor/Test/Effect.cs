using System;

namespace Tainobor.Test;

/// <summary>
/// Представляет эффект, который изменяет определённое значение на указанное количество.
/// </summary>
public class Effect(Enum name, int value)
{
    public Enum Name = name;
    public int Value { get; init; } = value;

}