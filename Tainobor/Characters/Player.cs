using Tainobor.Faculties;

namespace Tainobor.Characters;

/// <summary>
/// Представляет персонажа игрока, поступившего в академию Тайнобор.
/// </summary>
public class Player : Character
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender CharacterGender { get; set; }
    public int Age { get; set; } = 10;
    public Faculty FacultyName { get; set; } 
}