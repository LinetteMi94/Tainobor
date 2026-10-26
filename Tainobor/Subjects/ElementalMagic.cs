using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Стихиеведение» в Академии Тайнобор.
/// </summary>
public class ElementalMagic : Subject
{
    public override string Name => "Стихиеведение";
    public override Teacher Teacher => TeacherRepository.ElementalMagicTeacher!;
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
        Console.WriteLine("Это первый урок стихиеведения");
    }
    private void Lesson2()
    {
        Console.WriteLine("Это второй урок стихиеведения");
    }
    private void Lesson3()
    {
        Console.WriteLine("Это третий урок стихиеведения");
    }
}