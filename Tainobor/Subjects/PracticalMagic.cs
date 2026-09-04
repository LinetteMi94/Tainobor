using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Домоводство» в Академии Тайнобор.
/// </summary>
public class PracticalMagic : Subject
{
    public override string Name => "Домоводство";
    public override Teacher Teacher => TeacherRepository.PracticalMagicTeacher;
}