using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Звероведение
public class MagicalCreatures : Subject
{
    public override string Name => "Звероведение";
    public override Teacher Teacher => TeacherRepository.MagicalCreaturesTeacher;
}