using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Мироустройство» в Академии Тайнобор.
/// </summary>
public class MagicalSociety : Subject
{
    public override string Name => "Мироустройство";
    public override Teacher Teacher => TeacherRepository.MagicalSocietyTeacher!;
    protected internal override int MinYear { get; } = 5;
    protected override List<Lesson> Lessons { get; } = [];
    
    protected override void CreateLessons()
    {
        Lessons.Add(new Lesson(5, Lesson1));
        Lessons.Add(new Lesson(5, Lesson2));
        Lessons.Add(new Lesson(5, Lesson3));
    }

    private void Lesson1()
    {
        Console.WriteLine("Это первый урок мироустройства");
    }
    private void Lesson2()
    {
        Console.WriteLine("Это второй урок мироустройства");
    }
    private void Lesson3()
    {
        Console.WriteLine("Это третий урок мироустройства");
    }
}