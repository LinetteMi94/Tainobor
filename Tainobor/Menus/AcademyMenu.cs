using Tainobor.Characters;
using Tainobor.GameMessages;
using Tainobor.Input;

namespace Tainobor.Menus;

public static class AcademyMenu
{
    public static void ShowAcademyMenu(Action<string> handleChoice)
    {
        Console.Clear();
        Console.WriteLine("1. Узнать об академии");
        Console.WriteLine("2. Узнать о факультетах");
        Console.WriteLine("3. Выйти в главное меню");
        var choice = InputValidator.GetValidInput(null, 3).ToString();
        handleChoice(choice);
        Messages.Key();
    }
}