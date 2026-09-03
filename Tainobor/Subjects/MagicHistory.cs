using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Летопись магического мира
public class MagicHistory : Subject
{
    public override string Name => "Летопись магического мира";
    public override Teacher Teacher => TeacherRepository.MagicHistoryTeacher;
}