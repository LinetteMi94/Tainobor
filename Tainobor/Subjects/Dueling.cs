using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Поединки» в Академии Тайнобор.
/// </summary>
public class Dueling : Subject
{
    public override string Name => "Поединки";
    public override Teacher Teacher => TeacherRepository.DuelingTeacher;
    protected internal override int MinYear { get; } = 4;
    protected override List<Lesson> Lessons { get; } = [];
    
    protected internal override void CreateLessons()
    {
        Lessons.Add(new Lesson(4, Lesson1));
        Lessons.Add(new Lesson(4, Lesson2));
        Lessons.Add(new Lesson(4, Lesson3));
    }

    private void Lesson1(Player player)
    {
        Console.WriteLine("Это первый урок поединков");
    }
    private void Lesson2(Player player)
    {
        Console.WriteLine("Это второй урок поединков");
    }
    private void Lesson3(Player player)
    {
        Console.WriteLine("Это третий урок поединков");
    }
}