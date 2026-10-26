using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Руны» в Академии Тайнобор.
/// </summary>
public class Runes : Subject
{
    public override string Name => "Руны";
    public override Teacher Teacher => TeacherRepository.RunesTeacher!;
    protected internal override int MinYear { get; } = 3;
    protected override List<Lesson> Lessons { get; } = [];
    
    protected internal override void CreateLessons()
    {
        Lessons.Add(new Lesson(3, Lesson1));
        Lessons.Add(new Lesson(3, Lesson2));
        Lessons.Add(new Lesson(3, Lesson3));
    }

    private void Lesson1()
    {
        Console.WriteLine("Это первый урок рун");
    }
    private void Lesson2()
    {
        Console.WriteLine("Это второй урок рун");
    }
    private void Lesson3()
    {
        Console.WriteLine("Это третий урок рун");
    }
}