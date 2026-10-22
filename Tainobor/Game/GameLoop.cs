using System;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using Tainobor.Characters;
using Tainobor.GameMessages;
using Tainobor.Input;
using Tainobor.Locations;
using Tainobor.Menus;
using Tainobor.Test;
using Tainobor.Enums;

namespace Tainobor.Game;

/// <summary>
/// Управляет основным игровым циклом и последовательностью событий игры.
/// </summary>
public static class GameLoop
{
    private static Player _player;
    private static bool _isRunning;
    private static bool _academyInformationIsRunning;
    private static DayPeriod _currentPeriod = DayPeriod.Morning;
    private static GameDayOfWeek _currentDayOfWeek = GameDayOfWeek.Monday;
    
    /// <summary>
    /// Запускает игру и управляет последовательностью основных игровых этапов.
    /// </summary>
    public static void Start()
    {
        MainMenu.ShowMainMenu(HandleMainMenuChoice);
        while (_isRunning)
        {
            switch (_currentPeriod)
            {
                case DayPeriod.Morning:
                    _player.ShowGameMorningMenu(HandleGameMorningMenuChoice);
                    break;
                case DayPeriod.StudyTime:
                    _player.ShowGameStudyTimeMenu(HandleGameStudyTimeMenuChoice);
                    break;
                case DayPeriod.AfterClasses:
                    _player.ShowGameAfterClassesMenu(HandleGameAfterClassesMenuChoice);
                    break;
                case DayPeriod.Evening:
                    _player.ShowGameEveningMenu(HandleGameEveningMenuChoice);
                    break;
            }
        }
    }

    /// <summary>
    /// Создаёт персонажа игрока и запрашивает необходимые данные для его создания.
    /// </summary>
    private static void CreatePlayer()
    {
        _isRunning = true;
        WelcomeMessages.ShowFirstMessages();
        Messages.Print("Для начала укажи своё имя:");
        var firstName = Console.ReadLine()!;
        Messages.Print("\nА теперь фамилию:");
        var lastName = Console.ReadLine()!;
        Console.WriteLine();
        var textForChooseGender = "В реестре Тайнобора есть ещё одна важная запись.\nУкажи свой пол:\n1. Мужской\n2. Женский\n";
        int playerGender = textForChooseGender.GetValidInput(2);
        _player = new Player(firstName, lastName, playerGender == 1 ? Gender.Мужской : Gender.Женский);
        Messages.Print("Приятно познакомиться, " + _player.FirstName + " " + _player.LastName + ".\n \nТвоё имя внесено в реестр учеников Тайнобора.\n");
    }
    
    private static void CreateSchool()
    {
        School.CreateAcademy();
    }

    /// <summary>
    /// Проводит распределительный тест и определяет факультет игрока на основании его ответов.
    /// </summary>
    private static void TakeFacultyTest()
    {
        _player.ShowTestMenu();
        _player.FacultyName = FacultyTest.ChooseFaculty();
        Console.Clear();
        Messages.Print($"Распределение завершено. \n \nПо результатам испытания тебе присвоен факультет {_player.FacultyName}. \n  \nПоздравляем, {_player.FirstName}!");
        WelcomeMessages.ShowAdmissionMessages();
        Messages.Key();
    }
    
    /// <summary>
    /// Обрабатывает выбор игрока из главного меню
    /// и запускает соответствующее действие.
    /// </summary>
    private static void HandleMainMenuChoice(string choice)
    {
        _academyInformationIsRunning = true;
        switch (choice)
        {
            case "1":
                _isRunning = true;
                _player = new Player("Мария", "Королева", Gender.Женский)
                {
                    FacultyName = Faculty.Заговорье
                };
                CreateSchool();
                break;
            case "2":
                _isRunning = true;
                Console.Clear();
                CreatePlayer();
                TakeFacultyTest();
                CreateSchool();
                break;
            case "3":
                while (_academyInformationIsRunning)
                {
                    AcademyMenu.ShowAcademyMenu(HandleAcademyMenuChoice);
                }
                MainMenu.ShowMainMenu(HandleMainMenuChoice);
                break;
            case "4":
                break;
        }
    }
    
    /// <summary>
    /// Обрабатывает выбор игрока из меню академии
    /// и запускает соответствующее действие.
    /// </summary>
    private static void HandleAcademyMenuChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                Console.WriteLine("Узнать об академии");
                break;
            case "2":
                WelcomeMessages.ShowFacultyMessages();
                break;
            case "3":
                _academyInformationIsRunning = false;
                break;
        }
    }
    
    /// <summary>
    /// Обрабатывает выбор игрока из утреннего меню игрока
    /// и запускает соответствующее действие.
    /// </summary>
    private static void HandleGameMorningMenuChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                _player.DisplayCharacterStats();
                break;
            case 2:
                MorningPeriod.HaveBreakfast();
                break;
            case 3:
                Console.WriteLine("Вы смотрите своё расписание");
                break;
            case 4:
                Console.WriteLine("Вы пошли на занятия");
                _currentPeriod = DayPeriod.StudyTime;
                break;
            case 5:
                _isRunning = false;
                break;
        }
    }
    
    /// <summary>
    /// Обрабатывает выбор игрока из меню посещения занятий 
    /// и запускает соответствующее действие.
    /// </summary>
    private static void HandleGameStudyTimeMenuChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                _player.DisplayCharacterStats();
                break;
            case 2:
                Console.WriteLine("Вы посетили занятие");
                StudyTimePeriod.GoToLesson();
                _currentPeriod = DayPeriod.AfterClasses;
                break;
            case 3:
                Console.WriteLine("Вы выполняете практическое задание");
                break;
            case 4:
                _isRunning = false;
                break;
        }
    }
    
    /// <summary>
    /// Обрабатывает выбор игрока из меню после занятий 
    /// и запускает соответствующее действие.
    /// </summary>
    private static void HandleGameAfterClassesMenuChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                _player.DisplayCharacterStats();
                break;
            case 2:
                AfterClassesPeriod.GoToLibrary(_player);
                break;
            case 3:
                Console.WriteLine("Вы общаетесь с однокурсниками");
                break;
            case 4:
                Console.WriteLine("Вы практическуетесь в магии");
                break;
            case 5:
                Console.WriteLine("Вы отдыхаете");
                _currentPeriod = DayPeriod.Evening;
                break;
            case 6:
                _isRunning = false;
                break;
        }
    }
    
    /// <summary>
    /// Обрабатывает выбор игрока из вечернего меню игрока
    /// и запускает соответствующее действие.
    /// </summary>
    private static void HandleGameEveningMenuChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                _player.DisplayCharacterStats();
                break;
            case 2:
                Console.WriteLine("Вы готовитесь к завтрашнему дню");
                break;
            case 3:
                Console.WriteLine("Вы смотрите расписание");
                break;
            case 4:
                Console.WriteLine("Вы идёте спать");
                _currentPeriod = DayPeriod.Morning;
                _currentDayOfWeek++;
                if (_currentDayOfWeek == (GameDayOfWeek)8) _currentDayOfWeek = GameDayOfWeek.Monday;
                break;
            case 5:
                _isRunning = false;
                break;
        }
    }
    
    /// <summary>
    /// Отображает заголовок.
    /// </summary>
    /// <param name="player">Игрок, для которого отображается заголовок.</param>
    public static void ShowTitle(this Player player)
    {
        Console.Clear();
        Console.Clear();
        Console.WriteLine(" ------------------------ ");
        Console.WriteLine("|                        |");
        Console.WriteLine("|       ТАЙНОБОР         |");
        Console.WriteLine("|                        |");
        Console.WriteLine($"|      {_currentDayOfWeek.GetDescription()}      |");
        Console.WriteLine("|                        |");
        Console.WriteLine(" ------------------------ \n" );
    }
}