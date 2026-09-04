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
        new Question
        {
            Text = "Ты находишь в старой теплице неизвестное растение. Что сделаешь?",
            Answers =
            [
                new Answer
                {
                    AnswerText = "1. Осторожно изучу его внешний вид и свойства.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Корнецвет, Value = 1 },
                        new Effect { Name = Characteristics.Трудолюбие, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "2. Попробую выяснить, почему оно оказалось именно здесь.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Тайнор, Value = 1 },
                        new Effect { Name = Characteristics.Интуиция, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "3. Понаблюдаю, как оно взаимодействует с окружающими магическими силами.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Лесоведь, Value = 1 },
                        new Effect { Name = Characteristics.Ловкость, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "4. Сначала проверю, не представляет ли оно опасности для окружающих.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Живница, Value = 1 },
                        new Effect { Name = Characteristics.Дружелюбие, Value = 1 }
                    ]
                },
            ]
        },

        new Question
        {
            Text = "В библиотеке ты находишь книгу о магических существах. Что привлекает твоё внимание?",
            Answers =
            [
                new Answer
                {
                    AnswerText = "1. Описание поведения и повадок существ.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Лесоведь, Value = 1 },
                        new Effect { Name = Characteristics.Ловкость, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "2. Сведения о редких растениях, которыми они питаются.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Корнецвет, Value = 1 },
                        new Effect { Name = Characteristics.Трудолюбие, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "3. Старые записи о заклинаниях, связанных с существами.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Заговорье, Value = 1 },
                        new Effect { Name = Characteristics.Харизма, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "4. Неизвестные символы на полях книги.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Тайнор, Value = 1 },
                        new Effect { Name = Characteristics.Интуиция, Value = 1 }
                    ]
                }
            ]
        },

        new Question
        {
            Text =
                "На практическом занятии преподаватель предлагает освоить новое заклинание. Что для тебя важнее всего?",
            Answers =
            [
                new Answer
                {
                    AnswerText = "1. Узнать, насколько мощным оно может стать и какую силу скрывает.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Громоврат, Value = 1 },
                        new Effect { Name = Characteristics.Сила, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "2. Научиться выполнять его максимально точно.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Заговорье, Value = 1 },
                        new Effect { Name = Characteristics.Харизма, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "3. Понять принцип, по которому оно работает.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Тайнор, Value = 1 },
                        new Effect { Name = Characteristics.Интуиция, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "4. Узнать, как использовать его, чтобы помочь другим.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Живница, Value = 1 },
                        new Effect { Name = Characteristics.Дружелюбие, Value = 1 }
                    ]
                }
            ]
        },

        new Question
        {
            Text = "Ты замечаешь, что приручённое магическое существо ведёт себя необычно.",
            Answers =
            [
                new Answer
                {
                    AnswerText = "1. Попытаюсь понять, что оно пытается мне сообщить.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Лесоведь, Value = 1 },
                        new Effect { Name = Characteristics.Ловкость, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "2. Проверю, не связано ли его состояние с каким-нибудь растением или веществом.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Корнецвет, Value = 1 },
                        new Effect { Name = Characteristics.Трудолюбие, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "3. Поищу информацию о подобных случаях в старых книгах.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Тайнор, Value = 1 },
                        new Effect { Name = Characteristics.Интуиция, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "4. Попробую успокоить его с помощью магии.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Заговорье, Value = 1 },
                        new Effect { Name = Characteristics.Харизма, Value = 1 }
                    ]
                }
            ]
        },

        new Question
        {
            Text = "Во время прогулки начинается сильная гроза. Что ты сделаешь?",
            Answers =
            [
                new Answer
                {
                    AnswerText = "1. Найду безопасное место и помогу тем, кто оказался неподалёку.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Живница, Value = 1 },
                        new Effect { Name = Characteristics.Дружелюбие, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "2. Попытаюсь понять, насколько необычна эта гроза.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Тайнор, Value = 1 },
                        new Effect { Name = Characteristics.Интуиция, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "3. Буду наблюдать за стихией и постараюсь почувствовать её силу.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Громоврат, Value = 1 },
                        new Effect { Name = Characteristics.Сила, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "4. Проверю, как магические растения реагируют на грозу.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Корнецвет, Value = 1 },
                        new Effect { Name = Characteristics.Трудолюбие, Value = 1 }
                    ]
                }
            ]
        },

        new Question
        {
            Text = "Перед тобой старый артефакт. Ты понятия не имеешь, для чего он создан.",
            Answers =
            [
                new Answer
                {
                    AnswerText = "1. Попытаюсь найти способ активировать его.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Заговорье, Value = 1 },
                        new Effect { Name = Characteristics.Харизма, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "2. Изучу символы и надписи на нём.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Тайнор, Value = 1 },
                        new Effect { Name = Characteristics.Интуиция, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "3. Проверю, не связан ли он с целительной магией.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Живница, Value = 1 },
                        new Effect { Name = Characteristics.Дружелюбие, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "4. Попытаюсь определить, не заключена ли в нём сила какой-либо стихии.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Громоврат, Value = 1 },
                        new Effect { Name = Characteristics.Сила, Value = 1 }
                    ]
                }
            ]
        },

        new Question
        {
            Text = "Какой навык ты хотел бы получить?",
            Answers =
            [
                new Answer
                {
                    AnswerText = "1. Понимать язык магических существ.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Лесоведь, Value = 1 },
                        new Effect { Name = Characteristics.Ловкость, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "2. Создавать сложнейшие алхимические составы.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Корнецвет, Value = 1 },
                        new Effect { Name = Characteristics.Трудолюбие, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "3. Управлять силой огня, воды, воздуха и земли.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Громоврат, Value = 1 },
                        new Effect { Name = Characteristics.Сила, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "4. Создавать предметы, наделённые магическими свойствами.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Тайнор, Value = 1 },
                        new Effect { Name = Characteristics.Интуиция, Value = 1 }
                    ]
                }
            ]
        },

        new Question
        {
            Text = "Твой однокурсник случайно получил магическую травму.",
            Answers =
            [
                new Answer
                {
                    AnswerText = "1. Немедленно попытаюсь оказать ему помощь.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Живница, Value = 1 },
                        new Effect { Name = Characteristics.Дружелюбие, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "2. Постараюсь определить, какое заклинание вызвало травму.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Заговорье, Value = 1 },
                        new Effect { Name = Characteristics.Харизма, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "3. Поищу подходящее лечебное средство.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Корнецвет, Value = 1 },
                        new Effect { Name = Characteristics.Трудолюбие, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "4. Попытаюсь понять, какая магическая сила могла привести к такому результату.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Громоврат, Value = 1 },
                        new Effect { Name = Characteristics.Сила, Value = 1 }
                    ]
                }
            ]
        },

        new Question
        {
            Text = "У тебя появился свободный день в академии. Куда отправишься?",
            Answers =
            [
                new Answer
                {
                    AnswerText = "1. В лечебное крыло, чтобы узнать больше о целительной магии.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Живница, Value = 1 },
                        new Effect { Name = Characteristics.Дружелюбие, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "2. В зверинец или заповедную часть академии.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Лесоведь, Value = 1 },
                        new Effect { Name = Characteristics.Ловкость, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "3. На тренировочную площадку для стихийной магии.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Громоврат, Value = 1 },
                        new Effect { Name = Characteristics.Сила, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "4. В зал чар, чтобы самостоятельно потренироваться в заклинаниях.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Заговорье, Value = 1 },
                        new Effect { Name = Characteristics.Харизма, Value = 1 }
                    ]
                }
            ]
        },

        new Question
        {
            Text = "Тебе предлагают провести эксперимент. Что тебе интереснее всего?",
            Answers =
            [
                new Answer
                {
                    AnswerText = "1. Проверить, как изменение заклинания влияет на его результат.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Заговорье, Value = 1 },
                        new Effect { Name = Characteristics.Харизма, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "2. Исследовать неизвестное магическое вещество.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Корнецвет, Value = 1 },
                        new Effect { Name = Characteristics.Трудолюбие, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "3. Узнать, как магическая сила взаимодействует с окружающим миром.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Громоврат, Value = 1 },
                        new Effect { Name = Characteristics.Сила, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "4. Наблюдать за реакцией магического существа.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Лесоведь, Value = 1 },
                        new Effect { Name = Characteristics.Ловкость, Value = 1 }
                    ]
                }
            ]
        },

        new Question
        {
            Text = "Праздничный пир уже начался. Перед тобой стол, полный самых разных блюд. Что ты возьмёшь первым?",
            Answers =
            [
                new Answer
                {
                    AnswerText = "1. Блюдо с необычными травами и пряностями, которых ты никогда раньше не пробовал.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Корнецвет, Value = 1 },
                        new Effect { Name = Characteristics.Трудолюбие, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "2. Что-нибудь сладкое. Сегодня можно позволить себе маленький праздник.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Лесоведь, Value = 1 },
                        new Effect { Name = Characteristics.Ловкость, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText =
                        "3. Блюдо, которое пахнет свежим лесом. Ты выбираешь его, надеясь почувствовать вкус чего-то настоящего и природного.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Живница, Value = 1 },
                        new Effect { Name = Characteristics.Дружелюбие, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText =
                        "4. Блюдо, которое никто не решается попробовать первым. Именно поэтому тебе становится интересно, что в нём такого необычного.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Заговорье, Value = 1 },
                        new Effect { Name = Characteristics.Харизма, Value = 1 }
                    ]
                }
            ]
        },

        new Question
        {
            Text = "Что ты больше всего ценишь в жизни?",
            Answers =
            [
                new Answer
                {
                    AnswerText = "1. Образование.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Тайнор, Value = 1 },
                        new Effect { Name = Characteristics.Интуиция, Value = 1 },
                    ]
                },
                new Answer
                {
                    AnswerText = "2. Семья.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Лесоведь, Value = 1 },
                        new Effect { Name = Characteristics.Ловкость, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "3. Доброта.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Живница, Value = 1 },
                        new Effect { Name = Characteristics.Дружелюбие, Value = 1 }
                    ]
                },
                new Answer
                {
                    AnswerText = "4. Свобода.",
                    AnswerEffects = 
                    [
                        new Effect { Name = Faculty.Громоврат, Value = 1 },
                        new Effect { Name = Characteristics.Сила, Value = 1 }
                    ]
                }
            ]
        }
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


