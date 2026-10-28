namespace Tainobor.Models;

/// <summary>
/// Представляет урок определённого курса с соответствующим сценарием.
/// </summary>
/// <param name="course">Номер курса, на котором проводится урок.</param>
/// <param name="action">Метод, выполняющий сценарий урока.</param>
public class Lesson(int course, Action<Player> action)
{
   // public int Id { get; set; }
    public int Course { get; set; } = course;
    public Action<Player> Action { get; set; } = action;
}