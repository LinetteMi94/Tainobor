using System.Collections.Generic;

namespace Tainobor.Subjects;

/// <summary>
/// Предоставляет доступ к учебным предметам Академии Тайнобор и управляет их созданием.
/// </summary>
public static class SubjectRepository
{
    public static List<Subject> Subjects { get; } = new();
    public static Alchemy Alchemy { get; } = new ();
    public static ArtifactCrafting ArtifactCrafting { get; } = new ();
    public static Divination Divination { get; } = new ();
    public static Dueling Dueling { get; } = new ();
    public static ElementalMagic ElementalMagic { get; } = new ();
    public static Healing Healing { get; } = new ();
    public static Herbology Herbology { get; } = new ();
    public static MagicalCreatures MagicalCreatures { get; } = new ();
    public static MagicalSociety MagicalSociety { get; } = new ();
    public static MagicHistory MagicHistory { get; } = new ();
    public static PracticalMagic PracticalMagic { get; } = new ();
    public static ProtectionMagic ProtectionMagic { get; } = new ();
    public static Runes Runes { get; } = new ();
    public static Witchcraft Witchcraft { get; } = new ();
    
    public static List<Subject> CreateSubjects()
    {
        Subjects.Add(Alchemy);
        Subjects.Add(ArtifactCrafting);
        Subjects.Add(Divination);
        Subjects.Add(Dueling);
        Subjects.Add(ElementalMagic);
        Subjects.Add(Healing);
        Subjects.Add(Herbology);
        Subjects.Add(MagicalCreatures);
        Subjects.Add(MagicalSociety);
        Subjects.Add(MagicHistory);
        Subjects.Add(PracticalMagic);
        Subjects.Add(ProtectionMagic);
        Subjects.Add(Runes);
        Subjects.Add(Witchcraft);
        return Subjects;
    }
}