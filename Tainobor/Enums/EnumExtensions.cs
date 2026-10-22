using System;
using System.ComponentModel;

namespace Tainobor.Enums;

/// <summary>
/// Предоставляет методы расширения для работы с перечислениями.
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Возвращает описание элемента перечисления из атрибута <see cref="DescriptionAttribute"/>.
    /// Если атрибут отсутствует, возвращает имя элемента перечисления.
    /// </summary>
    /// <param name="value">Элемент перечисления, для которого необходимо получить описание.</param>
    /// <returns>Текстовое описание элемента перечисления или его имя, если описание не задано.</returns>
    public static string GetDescription(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());

        var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(
            field,
            typeof(DescriptionAttribute));

        return attribute?.Description ?? value.ToString();
    }
}