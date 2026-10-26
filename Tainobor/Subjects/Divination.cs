using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Вещевание» в Академии Тайнобор.
/// </summary>
public class Divination : Subject
{
    public override string Name => "Вещевание";
    public override Teacher Teacher => TeacherRepository.DivinationTeacher!;
    protected internal override int MinYear { get; } = 2;
    
    protected override List<Lesson> Lessons { get; } = [];
    
    protected override void CreateLessons()
    {
        Lessons.Add(new Lesson(2, Lesson1));
        Lessons.Add(new Lesson(2, Lesson2));
        Lessons.Add(new Lesson(2, Lesson3));
    }

    private void Lesson1()
    {
        Console.WriteLine("Это первый урок вещевания");
    }
    private void Lesson2()
    {
        Console.WriteLine("Это второй урок вещевания");
    }
    private void Lesson3()
    {
        Console.WriteLine("Это третий урок вещевания");
    }
}