using System;
using System.Collections.Generic;
using System.Linq;
using Tainobor.Characters;
using Tainobor.Enums;
using Tainobor.GameMessages;
using Tainobor.Input;

namespace Tainobor.Test;

/// <summary>
/// Содержит логику теста для определения факультета и первоначальных характеристик ученика.
/// </summary>
public static class FacultyTest
{
    private static Player _player = new ();
    
    private static List<Question> Questions { get;}=
    [
        new ("Ты находишь в старой теплице неизвестное растение. Что сделаешь?", 
        [
                    new Answer("1. Осторожно изучу его внешний вид и свойства.", 
                    [
                            new Effect(Faculty.Корнецвет, 1),
                            new Effect(Characteristics.Трудолюбие, 1)
                    ]),
                    new Answer("2. Попробую выяснить, почему оно оказалось именно здесь.", 
                    [
                            new Effect(Faculty.Тайнор, 1),
                            new Effect(Characteristics.Интуиция, 1)
                    ]),
                    new Answer("3. Понаблюдаю, как оно взаимодействует с окружающими магическими силами.", 
                    [
                            new Effect(Faculty.Лесоведь, 1),
                            new Effect(Characteristics.Ловкость, 1)
                    ]),
                    new Answer("4. Сначала проверю, не представляет ли оно опасности для окружающих.", 
                    [
                            new Effect(Faculty.Живница, 1),
                            new Effect(Characteristics.Дружелюбие, 1)
                    ])
        ]),
        
        new ("В библиотеке ты находишь книгу о магических существах. Что привлекает твоё внимание?", 
        [
            new Answer("1. Описание поведения и повадок существ.", 
            [
                new Effect(Faculty.Лесоведь, 1),
                new Effect(Characteristics.Ловкость, 1)
            ]),
            new Answer("2. Сведения о редких растениях, которыми они питаются.", 
            [
                new Effect(Faculty.Корнецвет, 1),
                new Effect(Characteristics.Трудолюбие, 1)
            ]),
            new Answer("3. Старые записи о заклинаниях, связанных с существами.", 
            [
                new Effect(Faculty.Заговорье, 1),
                new Effect(Characteristics.Харизма, 1)
            ]),
            new Answer("4. Неизвестные символы на полях книги.", 
            [
                new Effect(Faculty.Тайнор, 1),
                new Effect(Characteristics.Интуиция, 1)
            ])
        ]),
        
        new ("На практическом занятии преподаватель предлагает освоить новое заклинание. Что для тебя важнее всего?", 
        [
            new Answer("1. Узнать, насколько мощным оно может стать и какую силу скрывает.", 
            [
                new Effect(Faculty.Громоврат, 1),
                new Effect(Characteristics.Сила, 1)
            ]),
            new Answer("2. Научиться выполнять его максимально точно.", 
            [
                new Effect(Faculty.Заговорье, 1),
                new Effect(Characteristics.Харизма, 1)
            ]),
            new Answer("3. Понять принцип, по которому оно работает.", 
            [
                new Effect(Faculty.Тайнор, 1),
                new Effect(Characteristics.Интуиция, 1)
            ]),
            new Answer( "4. Узнать, как использовать его, чтобы помочь другим.", 
            [
                new Effect(Faculty.Живница, 1),
                new Effect(Characteristics.Дружелюбие, 1)
            ])
        ]),
        
        new ("Ты замечаешь, что приручённое магическое существо ведёт себя необычно.", 
        [
            new Answer("1. Попытаюсь понять, что оно пытается мне сообщить.", 
            [
                new Effect(Faculty.Лесоведь, 1),
                new Effect(Characteristics.Ловкость, 1)
            ]),
            new Answer("2. Проверю, не связано ли его состояние с каким-нибудь растением или веществом.", 
            [
                new Effect(Faculty.Корнецвет, 1),
                new Effect(Characteristics.Трудолюбие, 1)
            ]),
            new Answer("3. Поищу информацию о подобных случаях в старых книгах.", 
            [
                new Effect(Faculty.Тайнор, 1),
                new Effect(Characteristics.Интуиция, 1)
            ]),
            new Answer( "4. Попробую успокоить его с помощью магии.", 
            [
                new Effect(Faculty.Заговорье, 1),
                new Effect(Characteristics.Харизма, 1)
            ])
        ]),
        
        new ("Во время прогулки начинается сильная гроза. Что ты сделаешь?", 
        [
            new Answer("1. Найду безопасное место и помогу тем, кто оказался неподалёку.", 
            [
                new Effect(Faculty.Живница, 1),
                new Effect(Characteristics.Дружелюбие, 1)
            ]),
            new Answer("2. Попытаюсь понять, насколько необычна эта гроза.", 
            [
                new Effect(Faculty.Тайнор, 1),
                new Effect(Characteristics.Интуиция, 1)
            ]),
            new Answer("3. Буду наблюдать за стихией и постараюсь почувствовать её силу.", 
            [
                new Effect(Faculty.Громоврат, 1),
                new Effect(Characteristics.Сила, 1)
            ]),
            new Answer( "4. Проверю, как магические растения реагируют на грозу.", 
            [
                new Effect(Faculty.Корнецвет, 1),
                new Effect(Characteristics.Трудолюбие, 1)
            ])
        ]),

        new ("Перед тобой старый артефакт. Ты понятия не имеешь, для чего он создан.", 
        [
            new Answer("1. Попытаюсь найти способ активировать его.", 
            [
                new Effect(Faculty.Заговорье, 1),
                new Effect(Characteristics.Харизма, 1)
            ]),
            new Answer("2. Изучу символы и надписи на нём.", 
            [
                new Effect(Faculty.Тайнор, 1),
                new Effect(Characteristics.Интуиция, 1)
            ]),
            new Answer("3. Проверю, не связан ли он с целительной магией.", 
            [
                new Effect(Faculty.Живница, 1),
                new Effect(Characteristics.Дружелюбие, 1)
            ]),
            new Answer( "4. Попытаюсь определить, не заключена ли в нём сила какой-либо стихии.", 
            [
                new Effect(Faculty.Громоврат, 1),
                new Effect(Characteristics.Сила, 1)
            ])
        ]),

        new ("Какой навык ты хотел бы получить?", 
        [
            new Answer("1. Понимать язык магических существ.", 
            [
                new Effect(Faculty.Лесоведь, 1),
                new Effect(Characteristics.Ловкость, 1)
            ]),
            new Answer("2. Создавать сложнейшие алхимические составы.", 
            [
                new Effect(Faculty.Корнецвет, 1),
                new Effect(Characteristics.Трудолюбие, 1)
            ]),
            new Answer("3. Управлять силой огня, воды, воздуха и земли.", 
            [
                new Effect(Faculty.Громоврат, 1),
                new Effect(Characteristics.Сила, 1)
            ]),
            new Answer( "4. Создавать предметы, наделённые магическими свойствами.", 
            [
                new Effect(Faculty.Тайнор, 1),
                new Effect(Characteristics.Интуиция, 1)
            ])
        ]),
        
        new ("Твой однокурсник случайно получил магическую травму.", 
        [
            new Answer("1. Немедленно попытаюсь оказать ему помощь.", 
            [
                new Effect(Faculty.Живница, 1),
                new Effect(Characteristics.Дружелюбие, 1)
            ]),
            new Answer("2. Постараюсь определить, какое заклинание вызвало травму.", 
            [
                new Effect(Faculty.Заговорье, 1),
                new Effect(Characteristics.Харизма, 1)
            ]),
            new Answer("3. Поищу подходящее лечебное средство.", 
            [
                new Effect(Faculty.Корнецвет, 1),
                new Effect(Characteristics.Трудолюбие, 1)
            ]),
            new Answer( "4. Попытаюсь понять, какая магическая сила могла привести к такому результату.", 
            [
                new Effect(Faculty.Громоврат, 1),
                new Effect(Characteristics.Сила, 1)
            ])
        ]),

        new ("У тебя появился свободный день в академии. Куда отправишься?", 
        [
            new Answer("1. В лечебное крыло, чтобы узнать больше о целительной магии.", 
            [
                new Effect(Faculty.Живница, 1),
                new Effect(Characteristics.Дружелюбие, 1)
            ]),
            new Answer("2. В зверинец или заповедную часть академии.", 
            [
                new Effect(Faculty.Лесоведь, 1),
                new Effect(Characteristics.Ловкость, 1)
            ]),
            new Answer("3. На тренировочную площадку для стихийной магии.", 
            [
                new Effect(Faculty.Громоврат, 1),
                new Effect(Characteristics.Сила, 1)
            ]),
            new Answer( "4. В зал чар, чтобы самостоятельно потренироваться в заклинаниях.", 
            [
                new Effect(Faculty.Заговорье, 1),
                new Effect(Characteristics.Харизма, 1)
            ])
        ]),
        
        new ("Тебе предлагают провести эксперимент. Что тебе интереснее всего?", 
        [
            new Answer("1. Проверить, как изменение заклинания влияет на его результат.", 
            [
                new Effect(Faculty.Заговорье, 1),
                new Effect(Characteristics.Харизма, 1)
            ]),
            new Answer("2. Исследовать неизвестное магическое вещество.", 
            [
                new Effect(Faculty.Корнецвет, 1),
                new Effect(Characteristics.Трудолюбие, 1)
            ]),
            new Answer("3. Узнать, как магическая сила взаимодействует с окружающим миром.", 
            [
                new Effect(Faculty.Громоврат, 1),
                new Effect(Characteristics.Сила, 1)
            ]),
            new Answer( "4. Наблюдать за реакцией магического существа.", 
            [
                new Effect(Faculty.Лесоведь, 1),
                new Effect(Characteristics.Ловкость, 1)
            ])
        ]),
        
        new ("Праздничный пир уже начался. Перед тобой стол, полный самых разных блюд. Что ты возьмёшь первым?", 
        [
            new Answer("1. Блюдо с необычными травами и пряностями, которых ты никогда раньше не пробовал.", 
            [
                new Effect(Faculty.Корнецвет, 1),
                new Effect(Characteristics.Трудолюбие, 1)
            ]),
            new Answer("2. Что-нибудь сладкое. Сегодня можно позволить себе маленький праздник.", 
            [
                new Effect(Faculty.Лесоведь, 1),
                new Effect(Characteristics.Ловкость, 1)
            ]),
            new Answer("3. Блюдо, которое пахнет свежим лесом. Ты выбираешь его, надеясь почувствовать вкус чего-то настоящего и природного.", 
            [
                new Effect(Faculty.Живница, 1),
                new Effect(Characteristics.Дружелюбие, 1)
            ]),
            new Answer( "4. Блюдо, которое никто не решается попробовать первым. Именно поэтому тебе становится интересно, что в нём такого необычного.", 
            [
                new Effect(Faculty.Заговорье, 1),
                new Effect(Characteristics.Харизма, 1)
            ])
        ]),

        new ("Что ты больше всего ценишь в жизни?", 
        [
            new Answer("1. Образование.", 
            [
                new Effect(Faculty.Тайнор, 1),
                new Effect(Characteristics.Интуиция, 1)
            ]),
            new Answer("2. Семья.", 
            [
                new Effect(Faculty.Лесоведь, 1),
                new Effect(Characteristics.Ловкость, 1)
            ]),
            new Answer("3. Доброта.", 
            [
                new Effect(Faculty.Живница, 1),
                new Effect(Characteristics.Дружелюбие, 1)
            ]),
            new Answer( "4. Свобода.", 
            [
                new Effect(Faculty.Громоврат, 1),
                new Effect(Characteristics.Сила, 1)
            ])
        ])
    ];
    
    private static readonly Dictionary<Faculty, int> FacultiesCounter = new ()
    {
        [Faculty.Живница] = 0,
        [Faculty.Заговорье] = 0,
        [Faculty.Тайнор] = 0,
        [Faculty.Корнецвет] = 0,
        [Faculty.Лесоведь] = 0,
        [Faculty.Громоврат] = 0
    };

    /// <summary>
    /// Начисляет балл соответствующему факультету в зависимости от выбранного варианта ответа.
    /// Даёт балл характеристике игрока в зависимости от выбранного ответа
    /// </summary>
    private static void AddPoint(Effect effect)
    {
        if (effect.Name is Faculty faculty)
        {
            FacultiesCounter[faculty] += effect.Value;
        }
        if (effect.Name is Characteristics characteristic)
        {
            _player.PlayerCharacteristics[characteristic] += effect.Value;
        }
    }
    
    /// <summary>
    /// Определяет факультет ученика на основе набранных баллов.
    /// </summary>
    /// <returns>Факультет, набравший наибольшее количество баллов.</returns>
    public static Faculty ChooseFaculty()
    {
        int max = FacultiesCounter.Values.Max();
        var winners = FacultiesCounter
            .Where(x => x.Value == max)
            .Select(x => x.Key)
            .ToList();
        Faculty winner = winners[Random.Shared.Next(winners.Count)];
        return winner;
    }
    
    /// <summary>
    /// Выводит вопрос теста с указанным номером и обрабатывает ответ пользователя.
    /// </summary>
    /// <param name="number">Номер вопроса.</param>
    private static void AskQuestion(int number)
    {
        Console.Clear();
        Messages.Print(Questions[number].Text);
        Messages.ShowAllMessages(Questions[number].Answers.Select(x => x.AnswerText).ToList());
    }
    
    /// <summary>
    /// Запускает тестирование.
    /// </summary>
    public static void StartFacultyTest(this Player player)
    {
        _player = player;
        Console.Clear();
        for (int i = 0; i < Questions.Count; i++)
        {
            AskQuestion(i);
            var selectedOption = InputValidator.GetValidInput(null,4);
            Answer selectedAnswer = Questions[i].Answers[selectedOption - 1];
            foreach (Effect effect in selectedAnswer.AnswerEffects)
            {
                AddPoint(effect);
            }
        }
    }
}


