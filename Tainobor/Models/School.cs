using System.Collections.Generic;
using Tainobor.Data;

namespace Tainobor.Models;

public abstract class School
{
    
    public static List<Subject> Subjects { get; set; } = new();
    public static List<Teacher> Teachers { get; set; } = new();
    public static List<Faculty> Faculties { get; set; } = new();

    public static void CreateAcademy()
    {
        Teachers = TeacherRepository.CreateTeachers();
        Subjects = SubjectRepository.CreateSubjects();
        Faculties = FacultyRepository.CreateFaculties();
    }
}