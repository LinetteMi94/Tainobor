using System.Collections.Generic;
using Tainobor.Subjects;
using Tainobor.Characters.Teachers;

namespace Tainobor.Locations;

public abstract class School
{
    
    public static List<Subject> Subjects { get; set; } = new();
    public static List<Teacher> Teachers { get; set; } = new();

    public static void CreateAcademy()
    {
        Teachers = TeacherRepository.CreateTeachers();
        Subjects = SubjectRepository.CreateSubjects();
    }
}