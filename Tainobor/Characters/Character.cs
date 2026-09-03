using Tainobor.Enums;

namespace Tainobor.Characters;

/// <summary>
/// Представляет базового персонажа академии и содержит общие характеристики,
/// присущие игроку и другим персонажам.
/// </summary>
public abstract class Character
{
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public Gender CharacterGender { get; private set; }
    public int Age { get; private set; }
}