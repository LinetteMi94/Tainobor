using Tainobor.Enums;
using Tainobor.Models;

namespace Tainobor.Game;

/// <summary>
/// Управляет событиями и действиями игрока в учебный период дня.
/// </summary>
public static class StudyTimePeriod
{
    /// <summary>
    /// Позволяет ученику отправиться на урок.
    /// </summary>
    public static void GoToLesson(this Player player, GameDayOfWeek day)
    {
        if (day == GameDayOfWeek.Saturday || day == GameDayOfWeek.Sunday) return;
        var lessons = player.PlayerSchedule.First(x => x.dayOfWeek == day).Subjects;
        foreach (var lesson in lessons) lesson.StartLesson(player);
    }
}