using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Домоводство
public class PracticalMagic : Subject
{
    public override string Name => "Домоводство";
    public override Teacher Teacher => TeacherRepository.PracticalMagicTeacher;
}