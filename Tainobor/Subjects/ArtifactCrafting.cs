using Tainobor.Data;
using Tainobor.Models;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет учебный предмет «Артефакторика» в Академии Тайнобор.
/// </summary>
public class ArtifactCrafting : Subject
{
    public override string Name => "Артефакторика";
    public override Teacher Teacher => TeacherRepository.ArtifactCraftingTeacher!;
}