using Tainobor.Subjects;
using Tainobor.Characters.Teachers;

namespace Tainobor.Locations;

public class School
{
    public List<Subject> Subjects { get; } = new();
    public List<Teacher> Teachers { get; set; } = new();

    public void AddSubjects()
    {
        Teachers = TeacherRepository.CreateTeachers();
        Alchemy alchemy = new Alchemy();
        ArtifactCrafting artifactCrafting = new ArtifactCrafting();
        Subjects.Add(artifactCrafting);
        Subjects.Add(alchemy);
    }
}