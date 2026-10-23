using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

//Ворожба
public class Witchcraft : Subject
{
    public override string Name => "Ворожба";
    public override Teacher Teacher => TeacherRepository.WitchcraftTeacher!;
}