using System;
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
    /// Отображает утреннее меню игры для указанного игрока.
    /// </summary>
    /// <param name="player">Игрок, для которого отображается меню.</param>
    public static void ShowGameMorningMenu(this Player player, Action<int> handleChoice)
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
        Console.WriteLine("2. Позавтракать");
        Console.WriteLine("3. Посмотреть расписание");
        Console.WriteLine("4. Отправиться на занятия");
        Console.WriteLine("5. Выйти из игры");
        
        var choice = InputValidator.GetValidInput(null, 5);
        handleChoice(choice);
        
        Messages.Key();
    }
    
    /// <summary>
    /// Отображает меню посещения занятий для указанного игрока.
    /// </summary>
    /// <param name="player">Игрок, для которого отображается меню.</param>
    public static void ShowGameStudyTimeMenu(this Player player, Action<int> handleChoice)
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
        Console.WriteLine("2. Посетить занятие");
        Console.WriteLine("3. Выполнить практическое задание");
        Console.WriteLine("4. Выйти из игры");
        
        var choice = InputValidator.GetValidInput(null, 4);
        handleChoice(choice);
        
        Messages.Key();
    }
    
    /// <summary>
    /// Отображает меню после занятий для указанного игрока.
    /// </summary>
    /// <param name="player">Игрок, для которого отображается меню.</param>
    public static void ShowGameAfterClassesMenu(this Player player, Action<int> handleChoice)
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
        Console.WriteLine("2. Пойти в библиотеку");
        Console.WriteLine("3. Пообщаться с однокурсниками");
        Console.WriteLine("4. Практиковать магию");
        Console.WriteLine("5. Отдохнуть");
        Console.WriteLine("6. Выйти из игры");
        
        var choice = InputValidator.GetValidInput(null, 6);
        handleChoice(choice);
        
        Messages.Key();
    }
    
    /// <summary>
    /// Отображает вечернее меню игры для указанного игрока.
    /// </summary>
    /// <param name="player">Игрок, для которого отображается меню.</param>
    public static void ShowGameEveningMenu(this Player player, Action<int> handleChoice)
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
        Console.WriteLine("2. Подготовиться к завтрашнему дню");
        Console.WriteLine("3. Посмотреть расписание");
        Console.WriteLine("4. Лечь спать");
        Console.WriteLine("5. Выйти из игры");
        
        var choice = InputValidator.GetValidInput(null, 5);
        handleChoice(choice);
        
        Messages.Key();
    }
}