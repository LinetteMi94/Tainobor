using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Стихиеведение» в Академии Тайнобор.
/// </summary>
public class ElementalMagic : Subject
{
    public override string Name => "Стихиеведение";
    public override Teacher Teacher => TeacherRepository.ElementalMagicTeacher;
}