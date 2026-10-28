using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Домоводство» в Академии Тайнобор.
/// </summary>
public class PracticalMagic : Subject
{
    public override string Name => "Домоводство";
    public override Teacher Teacher => TeacherRepository.PracticalMagicTeacher!;
    protected internal override int MinYear { get; } = 1;
    protected override List<Lesson> Lessons { get; } = [];
    
    protected internal override void CreateLessons()
    {
        Lessons.Add(new Lesson(1, Lesson1));
        Lessons.Add(new Lesson(1, Lesson2));
        Lessons.Add(new Lesson(1, Lesson3));
    }

    private void Lesson1(Player player)
    {
        Console.WriteLine("Это первый урок домоводства");
    }
    private void Lesson2(Player player)
    {
        Console.WriteLine("Это второй урок домоводства");
    }
    private void Lesson3(Player player)
    {
        Console.WriteLine("Это третий урок домоводства");
    }
}