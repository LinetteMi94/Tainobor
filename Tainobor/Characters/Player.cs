using Tainobor.Enums;

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
    
    public Dictionary<Characteristics, int> PlayerCharacteristics { get; set; }  = new ()
    {
        [Characteristics.Дружелюбие] = 0,
        [Characteristics.Интуиция] = 0,
        [Characteristics.Ловкость] = 0,
        [Characteristics.Харизма] = 0,
        [Characteristics.Сила] = 0,
        [Characteristics.Трудолюбие] = 0
    };
}