using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Стихиеведение
public class ElementalMagic : Subject
{
    public override string Name => "Стихиеведение";
    public override Teacher Teacher => TeacherRepository.ElementalMagicTeacher;
}