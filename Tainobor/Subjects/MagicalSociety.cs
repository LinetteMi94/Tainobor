using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Мироустройство» в Академии Тайнобор.
/// </summary>
public class MagicalSociety : Subject
{
    public override string Name => "Мироустройство";
    public override Teacher Teacher => TeacherRepository.MagicalSocietyTeacher!;
    public override int MinYear { get; } = 5;
}