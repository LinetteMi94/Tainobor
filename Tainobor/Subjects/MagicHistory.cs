using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Летопись магического мира» в Академии Тайнобор.
/// </summary>
public class MagicHistory : Subject
{
    public override string Name => "Летопись магического мира";
    public override Teacher Teacher => TeacherRepository.MagicHistoryTeacher;
}