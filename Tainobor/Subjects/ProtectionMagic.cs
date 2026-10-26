using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Обережье» в Академии Тайнобор.
/// </summary>
public class ProtectionMagic : Subject
{
    public override string Name => "Обережье";
    public override Teacher Teacher => TeacherRepository.ProtectionMagicTeacher!;
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
        Console.WriteLine("Это первый урок обережья");
    }
    private void Lesson2()
    {
        Console.WriteLine("Это второй урок обережья");
    }
    private void Lesson3()
    {
        Console.WriteLine("Это третий урок обережья");
    }
}