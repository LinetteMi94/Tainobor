using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Вещевание
public class Divination : Subject
{
    public override string Name => "Вещевание";
    public override Teacher Teacher => TeacherRepository.DivinationTeacher;
}