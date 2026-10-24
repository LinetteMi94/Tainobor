using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Обережье» в Академии Тайнобор.
/// </summary>
public class ProtectionMagic : Subject
{
    public override string Name => "Обережье";
    public override Teacher Teacher => TeacherRepository.ProtectionMagicTeacher!;
    public override int MinYear { get; } = 1;
}