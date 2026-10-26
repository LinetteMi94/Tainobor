using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Врачевание» в Академии Тайнобор.
/// </summary>
public class Healing : Subject
{
    public override string Name => "Врачевание";
    public override Teacher Teacher => TeacherRepository.HealingTeacher!;
    protected internal override int MinYear { get; } = 1;
    protected override List<Lesson> Lessons { get; } = [];
    
    protected override void CreateLessons()
    {
        Lessons.Add(new Lesson(1, Lesson1));
        Lessons.Add(new Lesson(1, Lesson2));
        Lessons.Add(new Lesson(1, Lesson3));
    }

    private void Lesson1()
    {
        Console.WriteLine("Это первый урок врачевания");
    }
    private void Lesson2()
    {
        Console.WriteLine("Это второй урок врачевания");
    }
    private void Lesson3()
    {
        Console.WriteLine("Это третий урок врачевания");
    }
}