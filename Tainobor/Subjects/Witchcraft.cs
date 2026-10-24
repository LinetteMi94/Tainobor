using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Ворожба» в Академии Тайнобор.
/// </summary>
public class Witchcraft : Subject
{
    public override string Name => "Ворожба";
    public override Teacher Teacher => TeacherRepository.WitchcraftTeacher!;
    public override int MinYear { get; } = 1;
}