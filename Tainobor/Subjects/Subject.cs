using Tainobor.Characters.Teachers;

namespace Tainobor.Subjects;

/// <summary>
/// Представляет базовый класс для учебных предметов Академии Тайнобор.
/// </summary>
public abstract class Subject
{
    
    public abstract string Name { get; }
    public abstract Teacher Teacher { get; }
}