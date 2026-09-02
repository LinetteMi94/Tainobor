using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

//Артефакторика
public class ArtifactCrafting : Subject
{
    public override string Name => "Артефакторика";
    public override Teacher Teacher => TeacherRepository.ArtifactCraftingTeacher;
}