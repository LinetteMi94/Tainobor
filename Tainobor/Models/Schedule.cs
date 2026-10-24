using System.Collections.Generic;
using Tainobor.Enums;

namespace Tainobor.Models;

/// <summary>
/// Представляет расписание занятий ученика школы Тайнобор.
/// </summary>
public class Schedule
{
    public GameDayOfWeek dayOfWeek { get; set; }
    public List<Subject> Subjects { get; set; } = [];
    public FacultyNames Faculty { get; set; }
    
}