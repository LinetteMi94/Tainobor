using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Стихиеведение» в Академии Тайнобор.
/// </summary>
public class ElementalMagic : Subject
{
    public override string Name => "Стихиеведение";
    public override Teacher Teacher => TeacherRepository.ElementalMagicTeacher!;
    public override int MinYear { get; } = 1;
}