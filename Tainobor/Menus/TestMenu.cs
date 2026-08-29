using Tainobor.Input;
using Tainobor.GameMessages;

namespace Tainobor.Menus;

/// <summary>
/// Меню, связанное с прохождением вступительного теста.
/// </summary>
public static class TestMenu
{
    
    /// <summary>
    /// Отображает меню перед распределением на факультет.
    /// </summary>
    public static void ShowAdmissionMenu()
    {
       var choice =
            InputValidator.GetValidInput("Что ты хочешь сделать? \n1. Узнать о факультетах \n2. Пройти распределительный тест", 2);
       if (choice == 1)
       {
           WelcomeMessages.ShowFacultyMessages();
           Console.WriteLine("Нажми любую клавишу для продолжения...");
           Console.ReadKey();
       }
    }
    
    /// <summary>
    /// Отображает меню вступительного теста.
    /// </summary>
    public static void ShowTestMenu()
    {
        Messages.Print("Давай начнём тест!");
    }
}