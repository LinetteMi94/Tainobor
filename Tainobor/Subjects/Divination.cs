using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Вещевание» в Академии Тайнобор.
/// </summary>
public class Divination : Subject
{
    public override string Name => "Вещевание";
    public override Teacher Teacher => TeacherRepository.DivinationTeacher!;
    public override int MinYear { get; } = 2;
    
}