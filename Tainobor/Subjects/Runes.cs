using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Руны
public class Runes : Subject
{
    public override string Name => "Руны";
    public override Teacher Teacher => TeacherRepository.RunesTeacher;
}