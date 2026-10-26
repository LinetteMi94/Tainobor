using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Летопись магического мира» в Академии Тайнобор.
/// </summary>
public class MagicHistory : Subject
{
    public override string Name => "Летопись магического мира";
    public override Teacher Teacher => TeacherRepository.MagicHistoryTeacher!;
    protected internal override int MinYear { get; } = 1;
    protected override List<Lesson> Lessons { get; } = [];
    
    protected internal override void CreateLessons()
    {
        Lessons.Add(new Lesson(1, Lesson1));
        Lessons.Add(new Lesson(1, Lesson2));
        Lessons.Add(new Lesson(1, Lesson3));
    }

    private void Lesson1()
    {
        Console.WriteLine("Это первый урок летописи магического мира");
    }
    private void Lesson2()
    {
        Console.WriteLine("Это второй урок летописи магического мира");
    }
    private void Lesson3()
    {
        Console.WriteLine("Это третий урок летописи магического мира");
    }
}