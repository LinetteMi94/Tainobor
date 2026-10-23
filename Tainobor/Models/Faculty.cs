using Tainobor.Enums;
using Tainobor.GameMessages;

namespace Tainobor.Models;

/// <summary>
/// Представляет факультет школы Тайнобор.
/// </summary>
/// <param name="name">Название факультета.</param>
/// <param name="subject">Профильный предмет факультета.</param>
public class Faculty(FacultyNames name, Subject subject)
{
    public FacultyNames Name { get; set; } = name;
    public string Description { get; set; }
    public Subject SpecializationSubject { get; set; } = subject;

    public void ShowFacultyDescription() => Messages.ShowMessage(Description);
}