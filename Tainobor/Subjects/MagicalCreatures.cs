using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Звероведение» в Академии Тайнобор.
/// </summary>
public class MagicalCreatures : Subject
{
    public override string Name => "Звероведение";
    public override Teacher Teacher => TeacherRepository.MagicalCreaturesTeacher;
}