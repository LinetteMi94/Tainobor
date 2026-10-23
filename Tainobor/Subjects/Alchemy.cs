using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Алхимия» в Академии Тайнобор.
/// </summary>
public class Alchemy : Subject
{
    public override string Name => "Алхимия";

    public override Teacher Teacher => TeacherRepository.AlchemyTeacher!;
}