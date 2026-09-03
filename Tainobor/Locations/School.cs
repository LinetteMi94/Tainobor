using Tainobor.Subjects;
using Tainobor.Characters.Teachers;

namespace Tainobor.Locations;

public class School
{
    public List<Subject> Subjects { get; set; } = new();
    public List<Teacher> Teachers { get; set; } = new();

    public void AddSubjects()
    {
        Teachers = TeacherRepository.CreateTeachers();
        Subjects = SubjectRepository.CreateSubjects();
    }
}