using System.ComponentModel;

namespace Tainobor.Enums;

/// <summary>
/// Перечисляет дни недели в Академии Тайнобор.
/// Используется для определения текущего учебного дня и расписания занятий.
/// </summary>
public enum GameDayOfWeek
{
    [Description("Понедельник")]
    Monday = 1,
    
    [Description("Вторник")]
    Tuesday = 2,
    
    [Description("Среда")]
    Wednesday = 3,
    
    [Description("Четверг")]
    Thursday = 4,
    
    [Description("Пятница")]
    Friday = 5,
    
    [Description("Суббота")]
    Saturday = 6,
    
    [Description("Воскресенье")]
    Sunday = 7
}