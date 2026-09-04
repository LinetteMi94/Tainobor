using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Вещевание» в Академии Тайнобор.
/// </summary>
public class Divination : Subject
{
    public override string Name => "Вещевание";
    public override Teacher Teacher => TeacherRepository.DivinationTeacher;
}