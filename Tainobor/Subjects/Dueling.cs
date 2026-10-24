using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Поединки» в Академии Тайнобор.
/// </summary>
public class Dueling : Subject
{
    public override string Name => "Поединки";
    public override Teacher Teacher => TeacherRepository.DuelingTeacher;
    public override int MinYear { get; } = 4;
}