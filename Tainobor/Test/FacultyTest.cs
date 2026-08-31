using Tainobor.Faculties;
using Tainobor.GameMessages;
using Tainobor.Input;
using System.Linq;

namespace Tainobor.Test;

/// <summary>
/// Содержит логику теста для определения факультета ученика.
/// </summary>
public static class FacultyTest
{
    private static Dictionary<Faculty, int> _facultiesCounter = new ()
    {
        [Faculty.Живница] = 0,
        [Faculty.Заговорье] = 0,
        [Faculty.Тайнор] = 0,
        [Faculty.Корнецвет] = 0,
        [Faculty.Лесоведь] = 0,
        [Faculty.Громоврат] = 0
    };
    
    private static readonly List<string> TestMessages  =
    [
        "Ты находишь в старой теплице неизвестное растение. Что сделаешь?\n" +
        "1. Осторожно изучу его внешний вид и свойства.\n" +
        "2. Попробую выяснить, почему оно оказалось именно здесь.\n" +
        "3. Понаблюдаю, как оно взаимодействует с окружающими магическими силами.\n" +
        "4. Сначала проверю, не представляет ли оно опасности для окружающих.",
        
        "В библиотеке ты находишь книгу о магических существах. Что привлекает твоё внимание?\n" +
        "1. Описание поведения и повадок существ.\n" +
        "2. Сведения о редких растениях, которыми они питаются.\n" +
        "3. Старые записи о заклинаниях, связанных с существами.\n" +
        "4. Неизвестные символы на полях книги.",
        
        "На практическом занятии преподаватель предлагает освоить новое заклинание. Что для тебя важнее всего?\n" +
        "1. Узнать, насколько мощным оно может стать и какую силу скрывает.\n" +
        "2. Научиться выполнять его максимально точно.\n" +
        "3. Понять принцип, по которому оно работает.\n" +
        "4. Узнать, как использовать его, чтобы помочь другим.",
        
        "Ты замечаешь, что приручённое магическое существо ведёт себя необычно.\n" +
        "1. Попытаюсь понять, что оно пытается мне сообщить.\n" +
        "2. Проверю, не связано ли его состояние с каким-нибудь растением или веществом.\n" +
        "3. Поищу информацию о подобных случаях в старых книгах.\n" +
        "4. Попробую успокоить его с помощью магии.",
        
        "Во время прогулки начинается сильная гроза. Что ты сделаешь?\n" +
        "1. Найду безопасное место и помогу тем, кто оказался неподалёку.\n" +
        "2. Попытаюсь понять, насколько необычна эта гроза.\n" +
        "3. Буду наблюдать за стихией и постараюсь почувствовать её силу.\n" +
        "4. Проверю, как магические растения реагируют на грозу.",
        
        "Перед тобой старый артефакт. Ты понятия не имеешь, для чего он создан.\n" +
        "1. Попытаюсь найти способ активировать его.\n" +
        "2. Изучу символы и надписи на нём.\n" +
        "3. Проверю, не связан ли он с целительной магией.\n" +
        "4. Попытаюсь определить, не заключена ли в нём сила какой-либо стихии.",
        
        "Какой навык ты хотел бы получить?\n" +
        "1. Понимать язык магических существ.\n" +
        "2. Создавать сложнейшие алхимические составы.\n" +
        "3. Управлять силой огня, воды, воздуха и земли.\n" +
        "4. Создавать предметы, наделённые магическими свойствами.",
        
        "Твой однокурсник случайно получил магическую травму.\n" +
        "1. Немедленно попытаюсь оказать ему помощь.\n" +
        "2. Постараюсь определить, какое заклинание вызвало травму.\n" +
        "3. Поищу подходящее лечебное средство.\n" +
        "4. Попытаюсь понять, какая магическая сила могла привести к такому результату.",
        
        "У тебя появился свободный день в академии. Куда отправишься?\n" +
        "1. В лечебное крыло, чтобы узнать больше о целительной магии.\n" +
        "2. В зверинец или заповедную часть академии.\n" +
        "3. На тренировочную площадку для стихийной магии.\n" +
        "4. В зал чар, чтобы самостоятельно потренироваться в заклинаниях.",
        
        "Тебе предлагают провести эксперимент. Что тебе интереснее всего?\n" +
        "1. Проверить, как изменение заклинания влияет на его результат.\n" +
        "2. Исследовать неизвестное магическое вещество.\n" +
        "3. Узнать, как магическая сила взаимодействует с окружающим миром.\n" +
        "4. Наблюдать за реакцией магического существа.",
        
        "Праздничный пир уже начался. Перед тобой стол, полный самых разных блюд. Что ты возьмёшь первым?\n" +
        "1. Блюдо с необычными травами и пряностями, которых ты никогда раньше не пробовал.\n" +
        "2. Что-нибудь сладкое. Сегодня можно позволить себе маленький праздник.\n" +
        "3. Блюдо, которое пахнет свежим лесом. Ты выбираешь его, надеясь почувствовать вкус чего-то настоящего и природного.\n" +
        "4. Блюдо, которое никто не решается попробовать первым. Именно поэтому тебе становится интересно, что в нём такого необычного.",
        
        "Что ты больше всего ценишь в жизни?\n" +
        "1. Образование.\n" +
        "2. Семья.\n" +
        "3. Доброта.\n" +
        "4. Свобода."
    ];

    /// <summary>
    /// Определяет факультет ученика на основе набранных баллов.
    /// </summary>
    /// <returns>Факультет, набравший наибольшее количество баллов.</returns>
    public static Faculty ChooseFaculty()
    {
        int max = _facultiesCounter.Values.Max();
        var winners = _facultiesCounter
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
    public static void AskQuestion(int number)
    {
        Console.Clear();
        var selectedOption = InputValidator.GetValidInput(TestMessages[number],4);
        AddPoint(number, selectedOption);
    }
    
    /// <summary>
    /// Начисляет балл соответствующему факультету в зависимости от выбранного варианта ответа.
    /// </summary>
    /// <param name="number">Номер вопроса.</param>
    /// <param name="option">Выбранный вариант ответа.</param>  
    private static void AddPoint(int number, int option)
    {
        switch (number)
        {
            case 0:
                if (option == 1) _facultiesCounter[Faculty.Корнецвет]++;
                if (option == 2) _facultiesCounter[Faculty.Тайнор]++;
                if (option == 3) _facultiesCounter[Faculty.Лесоведь]++;
                if (option == 4) _facultiesCounter[Faculty.Живница]++;
                break;
            case 1:
                if (option == 1) _facultiesCounter[Faculty.Лесоведь]++;
                if (option == 2) _facultiesCounter[Faculty.Корнецвет]++;
                if (option == 3) _facultiesCounter[Faculty.Заговорье]++;
                if (option == 4) _facultiesCounter[Faculty.Тайнор]++;
                break;
            case 2:
                if (option == 1) _facultiesCounter[Faculty.Громоврат]++;
                if (option == 2) _facultiesCounter[Faculty.Заговорье]++;
                if (option == 3) _facultiesCounter[Faculty.Тайнор]++;
                if (option == 4) _facultiesCounter[Faculty.Живница]++;
                break;
            case 3:
                if (option == 1) _facultiesCounter[Faculty.Лесоведь]++;
                if (option == 2) _facultiesCounter[Faculty.Корнецвет]++;
                if (option == 3) _facultiesCounter[Faculty.Тайнор]++;
                if (option == 4) _facultiesCounter[Faculty.Заговорье]++;
                break;
            case 4:
                if (option == 1) _facultiesCounter[Faculty.Живница]++;
                if (option == 2) _facultiesCounter[Faculty.Тайнор]++;
                if (option == 3) _facultiesCounter[Faculty.Громоврат]++;
                if (option == 4) _facultiesCounter[Faculty.Корнецвет]++;
                break;
            case 5:
                if (option == 1) _facultiesCounter[Faculty.Заговорье]++;
                if (option == 2) _facultiesCounter[Faculty.Тайнор]++;
                if (option == 3) _facultiesCounter[Faculty.Живница]++;
                if (option == 4) _facultiesCounter[Faculty.Громоврат]++;
                break;
            case 6:
                if (option == 1) _facultiesCounter[Faculty.Лесоведь]++;
                if (option == 2) _facultiesCounter[Faculty.Корнецвет]++;
                if (option == 3) _facultiesCounter[Faculty.Громоврат]++;
                if (option == 4) _facultiesCounter[Faculty.Тайнор]++;
                break;
            case 7:
                if (option == 1) _facultiesCounter[Faculty.Живница]++;
                if (option == 2) _facultiesCounter[Faculty.Заговорье]++;
                if (option == 3) _facultiesCounter[Faculty.Корнецвет]++;
                if (option == 4) _facultiesCounter[Faculty.Громоврат]++;
                break;
            case 8:
                if (option == 1) _facultiesCounter[Faculty.Живница]++;
                if (option == 2) _facultiesCounter[Faculty.Лесоведь]++;
                if (option == 3) _facultiesCounter[Faculty.Громоврат]++;
                if (option == 4) _facultiesCounter[Faculty.Заговорье]++;
                break;
            case 9:
                if (option == 1) _facultiesCounter[Faculty.Заговорье]++;
                if (option == 2) _facultiesCounter[Faculty.Корнецвет]++;
                if (option == 3) _facultiesCounter[Faculty.Громоврат]++;
                if (option == 4) _facultiesCounter[Faculty.Лесоведь]++;
                break;
            case 10: 
                if (option == 1) _facultiesCounter[Faculty.Корнецвет]++;
                if (option == 2) _facultiesCounter[Faculty.Лесоведь]++;
                if (option == 3) _facultiesCounter[Faculty.Живница]++;
                if (option == 4) _facultiesCounter[Faculty.Заговорье]++;
                break;
            case 11:
                if (option == 1) _facultiesCounter[Faculty.Тайнор]++;
                if (option == 2) _facultiesCounter[Faculty.Лесоведь]++;
                if (option == 3) _facultiesCounter[Faculty.Живница]++;
                if (option == 4) _facultiesCounter[Faculty.Громоврат]++;
                break;
        }
    }
}


