using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Летопись магического мира» в Академии Тайнобор.
/// </summary>
public class MagicHistory : Subject
{
    public override string Name => "Летопись магического мира";
    public override Teacher Teacher => TeacherRepository.MagicHistoryTeacher!;
    public override int MinYear { get; } = 1;
}