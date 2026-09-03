using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Обережье
public class ProtectionMagic : Subject
{
    public override string Name => "Обережье";
    public override Teacher Teacher => TeacherRepository.ProtectionMagicTeacher;
}