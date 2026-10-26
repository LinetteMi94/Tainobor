using Tainobor.GameMessages;

namespace Tainobor.Models;

/// <summary>
/// Представляет базовый класс для учебных предметов Академии Тайнобор.
/// </summary>
public abstract class Subject
{
    
    public abstract string Name { get; }
    public abstract Teacher Teacher { get; }
    protected internal abstract int MinYear { get; }
    protected abstract List<Lesson> Lessons { get; }

    public void StartLesson()
    {
        var lesson = Lessons[0];
        lesson.Action();
        Lessons.RemoveAt(0);
    }
    protected internal abstract void CreateLessons();
}