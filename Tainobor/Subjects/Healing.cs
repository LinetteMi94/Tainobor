using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Врачевание» в Академии Тайнобор.
/// </summary>
public class Healing : Subject
{
    public override string Name => "Врачевание";
    public override Teacher Teacher => TeacherRepository.HealingTeacher!;
}