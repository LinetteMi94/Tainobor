using Tainobor.Characters;
using Tainobor.GameMessages;
using Tainobor.Input;

namespace Tainobor.Menus;

/// <summary>
/// Содержит главное меню игрока и управляет взаимодействием игрока с его пунктами.
/// </summary>
public static class GameMenu
{
    /// <summary>
    /// Отображает главное меню игры для указанного игрока.
    /// </summary>
    /// <param name="player">Игрок, для которого отображается меню.</param>
    public static void ShowGameMenu(this Player player, Action<string> handleChoice)
    {
        Console.Clear();
        Console.Clear();
        Console.WriteLine(" ------------------------ ");
        Console.WriteLine("|                        |");
        Console.WriteLine("|       ТАЙНОБОР         |");
        Console.WriteLine("|                        |");
        Console.WriteLine("|      Меню ученика      |");
        Console.WriteLine("|                        |");
        Console.WriteLine(" ------------------------ ");
        
        Console.WriteLine("1. Персонаж");
        Console.WriteLine("2. Выйти");
        
        var choice = InputValidator.GetValidInput(null, 2).ToString();
        handleChoice(choice);
        
        Messages.Key();
    }
}