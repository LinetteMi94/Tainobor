using System;
using System.Collections.Generic;
using Tainobor.Enums;

namespace Tainobor.Characters.Teachers;

/// <summary>
/// Предоставляет доступ к преподавателям Академии Тайнобор и управляет их созданием.
/// </summary>
public static class TeacherRepository
{
    private static List<Teacher> Teachers { get; } = new();
    private static Random random = new ();
    public static Teacher AlchemyTeacher { get; private set; } = new ();
    public static Teacher ArtifactCraftingTeacher { get; private set; } = new ();
    public static Teacher DivinationTeacher { get; private set; } = new ();
    public static Teacher DuelingTeacher { get; private set; } = new ();
    public static Teacher ElementalMagicTeacher { get; private set; } = new ();
    public static Teacher HealingTeacher { get; private set; } = new ();
    public static Teacher HerbologyTeacher { get; private set; }  = new ();
    public static Teacher MagicalCreaturesTeacher { get; private set; } = new ();
    public static Teacher MagicalSocietyTeacher { get; private set; } = new ();
    public static Teacher MagicHistoryTeacher { get; private set; } = new ();
    public static Teacher PracticalMagicTeacher { get; private set; } = new ();
    public static Teacher ProtectionMagicTeacher { get; private set; }  = new ();
    public static Teacher RunesTeacher { get; private set; } = new ();
    public static Teacher WitchcraftTeacher { get; private set; } = new ();
   


    private static string[] MaleNames = 
   [
       "Велимир", "Яромир", "Радомир", "Святозар", "Мирослав", "Богдан", "Владимир", "Добромир", "Станислав",
       "Ростислав", "Всеволод", "Святослав", "Ратибор", "Горислав", "Милорад", "Ладомир", "Вячеслав",
       "Златомир", "Ярослав", "Владислав", "Олег", "Родион", "Тихомир", "Мстислав", "Любомир", "Арсений",
       "Тимофей", "Лукьян", "Фадей", "Макар"
   ];
    private static string[] FemaleNames =
    [
        "Аглая", "Мирослава", "Лада", "Милена", "Злата", "Ярослава", "Любомира", "Радослава",
        "Велена", "Дарина", "Влада", "Зоряна", "Веслава", "Добромира", "Огнеслава", "Станислава",
        "Лукерия", "Василиса", "Серафима", "Таисия", "Веста", "Леля", "Снежана", "Иллария",
        "Аврора", "Аделина", "Арина", "Лиана", "Мирель", "Невея" 
    ];

    private static string[] LastNames =
    [
        "Ворон", "Сокол", "Ястреб", "Грач", "Филин","Журавль", "Лебедь", "Коготь", "Клык", "Рог", "Гром",
        "Шторм", "Вихрь", "Ветер", "Туман", "Сумрак", "Мрак", "Свет", "Луч", "Прах", "Пепел", "Уголь",
        "Жар", "Огонь", "Иней", "Мороз", "Лёд", "Камень", "Янтарь", "Хрусталь", "Берест", "Дуб", "Ясень",
        "Клён", "Лес", "Корень", "Лист", "Вереск", "Мох", "Ручей", "Роса", "Заря", "Луна", "Звезда",
        "Небо", "Облак", "Полночь", "Рассвет", "Закат", "Север", "Оберег", "Знак", "След", "Шёпот", "Зов",
        "Слово", "Руна", "Печать", "Ключ", "Свиток", "Тень", "Тайна", "Мираж", "Сон", "Взор", "Память",
        "Эхо", "Грань", "Предел", "Путь"
    ];
    
    private static void CreateAlchemyTeacher() => AlchemyTeacher = CreateTeacher();
    private static void CreateArtifactCraftingTeacher() => ArtifactCraftingTeacher = CreateTeacher();
    private static void CreateDivinationTeacher() => DivinationTeacher = CreateTeacher();
    private static void CreateDuelingTeacher() => DuelingTeacher = CreateTeacher();
    private static void CreateElementalMagicTeacher() => ElementalMagicTeacher = CreateTeacher();
    private static void CreateHealingTeacher() => HealingTeacher = CreateTeacher();
    private static void CreateHerbologyTeacher() => HerbologyTeacher = CreateTeacher();
    private static void CreateMagicalCreaturesTeacher() => MagicalCreaturesTeacher = CreateTeacher();
    private static void CreateMagicalSocietyTeacher() => MagicalSocietyTeacher = CreateTeacher();
    private static void CreateMagicHistoryTeacher() => MagicHistoryTeacher = CreateTeacher();
    private static void CreatePracticalMagicTeacher() => PracticalMagicTeacher = CreateTeacher();
    private static void CreateProtectionMagicTeacher() => ProtectionMagicTeacher = CreateTeacher();
    private static void CreateRunesTeacher() => RunesTeacher = CreateTeacher();
    private static void CreateWitchcraftTeacher() => WitchcraftTeacher = CreateTeacher();
    

    /// <summary>
    /// Создаёт нового преподавателя со случайным именем и фамилией.
    /// </summary>
    /// <returns>Созданный преподаватель.</returns>
    private static Teacher CreateTeacher()
    {
        Teacher tempTeacher = new Teacher();
        switch (random.Next(1, 3))
        {
            case 1: 
                tempTeacher.CharacterGender = Gender.Мужской;
                tempTeacher.Name = MaleNames[random.Next(MaleNames.Length)];
                break;
            case 2:
                tempTeacher.CharacterGender = Gender.Женский;
                tempTeacher.Name = FemaleNames[random.Next(FemaleNames.Length)];
                break;
        }
        tempTeacher.LastName = LastNames[random.Next(LastNames.Length)];
        tempTeacher.Age = random.Next(25, 61);
        Teachers.Add(tempTeacher);
        return tempTeacher;
    }
    
    /// <summary>
    /// Создаёт преподавателей Академии Тайнобор.
    /// </summary>
    /// <returns>Список созданных преподавателей.</returns>
    public static List<Teacher> CreateTeachers()
    {
        CreateAlchemyTeacher();
        CreateArtifactCraftingTeacher();
        CreateDivinationTeacher();
        CreateDuelingTeacher();
        CreateElementalMagicTeacher();
        CreateHealingTeacher();
        CreateHerbologyTeacher();
        CreateMagicalCreaturesTeacher();
        CreateMagicalSocietyTeacher();
        CreateMagicHistoryTeacher();
        CreatePracticalMagicTeacher();
        CreateProtectionMagicTeacher();
        CreateRunesTeacher();
        CreateWitchcraftTeacher();
        return Teachers;
    }
}