using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Мироустройство» в Академии Тайнобор.
/// </summary>
public class MagicalSociety : Subject
{
    public override string Name => "Мироустройство";
    public override Teacher Teacher => TeacherRepository.MagicalSocietyTeacher;
}