using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Руны» в Академии Тайнобор.
/// </summary>
public class Runes : Subject
{
    public override string Name => "Руны";
    public override Teacher Teacher => TeacherRepository.RunesTeacher;
}