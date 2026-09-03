using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Мироустройство
public class MagicalSociety : Subject
{
    public override string Name => "Мироустройство";
    public override Teacher Teacher => TeacherRepository.MagicalSocietyTeacher;
}