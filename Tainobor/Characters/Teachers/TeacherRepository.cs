namespace Tainobor.Characters.Teachers;

public static class TeacherRepository
{
    private static List<Teacher> Teachers { get; } = new();
    private static Random random = new ();
    public static Teacher AlchemyTeacher { get; set; } = new ();
    public static Teacher ArtifactCraftingTeacher { get; set; } = new ();
   // public static Teacher HerbologyTeacher { get; } 
   


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

    private static Teacher CreateTeacher()
    {
        Teacher tempTeacher = new Teacher();
        switch (random.Next(1, 3))
        {
            case 1: 
                tempTeacher.CharacterGender = Gender.Male;
                tempTeacher.Name = MaleNames[random.Next(MaleNames.Length)];
                break;
            case 2:
                tempTeacher.CharacterGender = Gender.Female;
                tempTeacher.Name = FemaleNames[random.Next(FemaleNames.Length)];
                break;
        }
        tempTeacher.LastName = LastNames[random.Next(LastNames.Length)];
        Teachers.Add(tempTeacher);
        return tempTeacher;
    }
    public static List<Teacher> CreateTeachers()
    {
        CreateAlchemyTeacher();
        CreateArtifactCraftingTeacher();
        return Teachers;
    }
}