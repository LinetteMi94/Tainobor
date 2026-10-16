using Tainobor.Characters;
using Tainobor.GameMessages;
using Tainobor.Menus;

namespace Tainobor.Game;

/// <summary>
/// Управляет событиями и действиями игрока в период дня после занятий.
/// </summary>
public static class AfterClassesPeriod
{

    private static bool _isLibraryOpen = true;
    public static void GoToLibrary(Player player)
    {
        Messages.Print("Ты открываешь массивную дубовую дверь и входишь в библиотеку Тайнобора.");
        _isLibraryOpen = true;
        while (_isLibraryOpen)
        {
            GameMenu.ShowLibraryMenu(player, HandleLibraryMenuChoice);
        }
    }
    
    /// <summary>
    /// Обрабатывает выбор игрока из меню библиотеки
    /// и запускает соответствующее действие.
    /// </summary>
    private static void HandleLibraryMenuChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                Messages.Print("Ты неспешно прогуливаешься между книжными стеллажами, разглядывая " +
                               "старинные переплёты и потемневшие от времени корешки. Некоторые книги скреплены " +
                               "металлическими застёжками, другие покрыты незнакомыми рунами, которые едва " +
                               "заметно мерцают в полумраке.");
                Messages.Print("У окна расположились несколько учеников. Один старательно переписывает " +
                               "заклинание в тетрадь, другой дремлет над раскрытым учебником, время от времени " +
                               "вздрагивая от шороха страниц.");
                Messages.Print("В дальнем углу ты замечаешь небольшой стол, заваленный свитками и книгами " +
                               "без названий. Рядом стоит пустое кресло, а на столешнице лежит тонкая " +
                               "серебряная закладка в форме полумесяца.");
                Messages.Print("Библиотека кажется тихим и спокойным местом, но чем дольше ты здесь " +
                               "находишься, тем сильнее ощущаешь: у этих стен гораздо больше историй, чем " +
                               "может показаться на первый взгляд.");
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                Messages.Print("Ты направляешься к выходу.Тяжёлая дубовая дверь бесшумно закрывается за тобой.");
                _isLibraryOpen = false;
                break;
        }
    }
}