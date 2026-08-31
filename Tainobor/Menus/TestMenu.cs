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
    public static void ShowAdmissionMenu()
    {
       var choice =
            InputValidator.GetValidInput("Что ты хочешь сделать? \n1. Узнать о факультетах \n2. Пройти распределительный тест", 2);
       if (choice == 1)
       {
           WelcomeMessages.ShowFacultyMessages();
           Messages.Key();
       }
    }
    
    /// <summary>
    /// Отображает меню вступительного теста.
    /// </summary>
    public static void ShowTestMenu()
    {
        WelcomeMessages.ShowInAcademyMessages();
        Messages.Key();
        for (int i = 0; i < 12; i++)
        {
            FacultyTest.AskQuestion(i);
        }
    }
}