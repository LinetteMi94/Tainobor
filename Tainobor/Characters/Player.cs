using System.Collections.Generic;
using Tainobor.Enums;

namespace Tainobor.Characters;

/// <summary>
/// Представляет персонажа игрока, поступившего в академию Тайнобор.
/// </summary>
public class Player(string name, string lastName, Gender characterGender, int age = 10)
    : Character(name, lastName, characterGender, age)
{
    public string FirstName { get; set; } = name;
    public new string LastName { get; set; } = lastName;
    public new Gender CharacterGender { get; set; } = characterGender;

    public new int Age { get; set; } = age;
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
    
    /// <summary>
    /// Выводит информацию об игроке
    /// </summary>
    public void DisplayCharacterStats()
    {
        Console.Write(CharacterGender == Gender.Женский ? "Ученица " : "Ученик ");
        Console.WriteLine($"{FirstName} {LastName}, {Age} лет - 1 курс факультета {FacultyName}\n");
        Console.WriteLine("Характеристики:");
        foreach (var character in PlayerCharacteristics)
        {
            Console.WriteLine($"{character.Key}: {character.Value}");
        }
        Console.WriteLine();
    }
}