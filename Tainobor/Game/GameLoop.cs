using System;
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
    
    /// <summary>
    /// Запускает игру и управляет последовательностью основных игровых этапов.
    /// </summary>
    public static void Start()
    {
        Console.Clear();
        //CreatePlayer();
        //TakeFacultyTest();
        CreateSchool();
        _player.ShowMainMenu();
    }

    /// <summary>
    /// Создаёт персонажа игрока и запрашивает необходимые данные для его создания.
    /// </summary>
    private static void CreatePlayer()
    { 
        WelcomeMessages.ShowFirstMessages();
        Messages.Print("Для начала укажи своё имя:");
        _player.FirstName = Console.ReadLine()!;
        Console.WriteLine();
        Messages.Print("А теперь фамилию:");
        _player.LastName = Console.ReadLine()!;
        Console.WriteLine();
        var textForChooseGender = "В реестре Тайнобора есть ещё одна важная запись.\nУкажи свой пол:\n1. Мужской\n2. Женский\n";
        int playerGender = textForChooseGender.GetValidInput(2);
        _player.CharacterGender = playerGender == 1 ? Gender.Мужской : Gender.Женский;
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
    }
}