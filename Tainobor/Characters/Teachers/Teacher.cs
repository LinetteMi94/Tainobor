using Tainobor.Enums;

namespace Tainobor.Characters.Teachers;

/// <summary>
/// Представляет преподавателя Академии Тайнобор.
/// Содержит информацию о персонаже и может быть связан с одним или несколькими учебными предметами.
/// </summary>
public class Teacher : Character
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public Gender CharacterGender { get; set; }
    public int Age { get; set; }
}