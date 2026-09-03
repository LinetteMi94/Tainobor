using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Врачевание
public class Healing : Subject
{
    public override string Name => "Врачевание";
    public override Teacher Teacher => TeacherRepository.HealingTeacher;
}