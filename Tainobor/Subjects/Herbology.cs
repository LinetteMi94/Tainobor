using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Травничество
public class Herbology : Subject
{
    public override string Name => "Травничество";
    public override Teacher Teacher => TeacherRepository.HerbologyTeacher;
}