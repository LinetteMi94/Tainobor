using Tainobor.Enums;

namespace Tainobor.Characters.Teachers;

/// <summary>
/// Представляет преподавателя Академии Тайнобор.
/// Содержит информацию о персонаже и может быть связан с одним или несколькими учебными предметами.
/// </summary>
public class Teacher(string name, string lastName, Gender characterGender, int age)
    : Character(name, lastName, characterGender, age)
{
    public string Personality { get; set; }
    public string Specialization { get; set; }
    public string FavoritePhrase { get; set; }
    public string AttitudeToStudents { get; set; }
    public string AttitudeToSubject { get; set; }
    public string SpecialFeature { get; set; }
    public string Appearance { get; set; }
}