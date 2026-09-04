using Tainobor.Characters;
using Tainobor.Input;
using Tainobor.GameMessages;
using Tainobor.Test;

namespace Tainobor.Menus;

/// <summary>
/// Меню, связанное с прохождением вступительного теста.
/// </summary>
public static class TestMenu
{
    
    /// <summary>
    /// Отображает меню перед распределением на факультет.
    /// </summary>
    public static void ShowTestMenu(this Player player)
    {
       var choice =
           InputValidator.GetValidInput("Что ты хочешь сделать? \n1. Узнать о факультетах \n2. Пройти распределительный тест", 2);
       if (choice == 1)
       {
           WelcomeMessages.ShowFacultyMessages();
           Messages.Key();
       }
       WelcomeMessages.ShowInAcademyMessages();
       Messages.Key();
       player.StartFacultyTest();
    }
}