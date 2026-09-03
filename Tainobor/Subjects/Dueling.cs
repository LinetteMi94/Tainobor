using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Поединки
public class Dueling : Subject
{
    public override string Name => "Поединки";
    public override Teacher Teacher => TeacherRepository.DivinationTeacher;
}