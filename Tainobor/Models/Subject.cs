using Tainobor.Enums;
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

    public void StartLesson(Player player)
    {
        var lesson = Lessons[0];
        lesson.Action(player);
        Lessons.RemoveAt(0);
    }
    protected internal abstract void CreateLessons();
    
    /// <summary>
    /// Оценивает результат выполнения задания на основе характеристики игрока.
    /// </summary>
    /// <param name="player">Игрок, результат которого оценивается.</param>
    /// <param name="characteristics">Характеристика игрока, влияющая на результат выполнения задания.</param>
    /// <returns>Оценка за выполнение задания.</returns>
    protected LessonGrade AssessResult(Player player, Characteristics characteristics)
    {
        var score = player.PlayerCharacteristics[characteristics] + new Random().Next(5);
        return score switch
        {
            < 4 => LessonGrade.Неудача,
            < 6 => LessonGrade.Удовлетворительно,
            < 8 => LessonGrade.Хорошо,
            _ => LessonGrade.Превосходно
        };
    }
}