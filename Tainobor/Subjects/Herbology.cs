using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Травничество» в Академии Тайнобор.
/// </summary>
public class Herbology : Subject
{
    public override string Name => "Травничество";
    public override Teacher Teacher => TeacherRepository.HerbologyTeacher;
}