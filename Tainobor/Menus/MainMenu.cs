using Tainobor.Input;

namespace Tainobor.Menus;

/// <summary>
/// Содержит главное меню для входа в сохранённую игру.
/// </summary>
public static class MainMenu
{
    public static void ShowMainMenu(Action<string> handleChoice)
    {
        Console.Clear();
        Console.WriteLine(" ------------------------ ");
        Console.WriteLine("|                        |");
        Console.WriteLine("|       ТАЙНОБОР         |");
        Console.WriteLine("|                        |");
        Console.WriteLine("|    Академия магии      |");
        Console.WriteLine("|                        |");
        Console.WriteLine(" ------------------------ ");
        
        Console.WriteLine("1. Продолжить игру");
        Console.WriteLine("2. Новая игра");
        Console.WriteLine("3. Об академии");
        Console.WriteLine("4. Выйти");
        
        var choice = InputValidator.GetValidInput(null, 4).ToString();
        handleChoice(choice);
    }
}