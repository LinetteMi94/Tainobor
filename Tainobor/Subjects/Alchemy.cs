using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Алхимия
public class Alchemy : Subject
{
    public override string Name => "Алхимия";

    public override Teacher Teacher => TeacherRepository.AlchemyTeacher;
}