using System;
using System.Collections.Generic;
using System.Linq;
using Tainobor.Data;
using Tainobor.Enums;

namespace Tainobor.Models;

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
    public Faculty PlayerFaculty { get; set; }
    public int Year { get; set; } = 1;
    public List<Schedule> PlayerSchedule { get; set; } 
    
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
    /// Создаёт расписание занятий на учебную неделю.
    /// </summary>
    public void CreateSchedule()
    {
        PlayerSchedule = new List<Schedule>();
        var random = new Random();
        var subjects = SubjectRepository.Subjects.Where(x => x.MinYear <= Year).ToList();
        for (int i = 0; i < 5; i++)
        {
            var schedule = new Schedule();
            schedule.dayOfWeek = (GameDayOfWeek)(i+1);
            schedule.Faculty = PlayerFaculty.Name;
            var subject1 = subjects[random.Next(subjects.Count)];
            schedule.Subjects.Add(subject1);
            subjects.Remove(subject1);
            var subject2 = subjects[random.Next(subjects.Count)];
            schedule.Subjects.Add(subject2);
            subjects.Remove(subject2);
            PlayerSchedule.Add(schedule);
        }
    }
    
    /// <summary>
    /// Выводит информацию об игроке
    /// </summary>
    public void DisplayCharacterStats()
    {
        Console.Write(CharacterGender == Gender.Женский ? "Ученица " : "Ученик ");
        Console.WriteLine($"{FirstName} {LastName}, {Age} лет - {Year} курс факультета {PlayerFaculty.Name}\n");
        Console.WriteLine("Характеристики:");
        foreach (var character in PlayerCharacteristics)
        {
            Console.WriteLine($"{character.Key}: {character.Value}");
        }
        Console.WriteLine();
    }
    
    /// <summary>
    /// Отображает расписание занятий на указанный день недели.
    /// </summary>
    /// <param name="day">День недели, для которого отображается расписание.</param>
    public void ShowSchedule(GameDayOfWeek day)
    {
        if (day == GameDayOfWeek.Saturday || day == GameDayOfWeek.Sunday)
        {
            Console.WriteLine($"{day.GetDescription()} - выходной!");
            return;
        }
        PlayerSchedule.First(x => x.dayOfWeek == day)
            .Subjects.Select((subject, index) => $"{index + 1}. {subject.Name}")
            .ToList().ForEach(Console.WriteLine);
    }
}