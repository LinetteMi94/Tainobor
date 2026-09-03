using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Ворожба
public class Witchcraft : Subject
{
    public override string Name => "Ворожба";
    public override Teacher Teacher => TeacherRepository.WitchcraftTeacher;
}