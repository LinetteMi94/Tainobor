namespace Tainobor.GameMessages;

/// <summary>
/// Представляет базовый класс для сообщений, используемых в игре.
/// Содержит общие методы для вывода игровых сообщений.
/// </summary>
public abstract class Messages
{
    /// <summary>
    /// Выводит случайное сообщение из переданного списка.
    /// </summary>
    /// <param name="messages">Список сообщений, из которого выбирается случайное.</param>
    public static void ShowMessage(List<string> messages)
    {
        string message = messages[new Random().Next(messages.Count)];
        TypeText(message);
    }
    
    /// <summary>
    /// Выводит сообщение на консоль.
    /// </summary>
    /// <param name="message">Сообщение, которое необходимо вывести.</param>
    public static void Print(string? message) => TypeText(message);
    
    /// <summary>
    /// Выводит все сообщения из переданного списка.
    /// </summary>
    /// <param name="messages">Список сообщений для вывода.</param>
    public static void ShowAllMessages(List<string> messages)
    {
        foreach (var message in messages)
        {
            TypeText(message);
            Console.WriteLine();
        }
    }
    
    /// <summary>
    /// Выводит конкретное сообщение из переданного списка.
    /// </summary>
    /// <param name="messages">Список сообщений для поиска нужного.</param>
    /// <param name="number">Номер нужного сообщения.</param>
    public static void ShowThisMessage(List<string> messages, int number)
    {
        var message = messages[number];
        TypeText(message);
    }

    public static void Key()
    {
        Console.WriteLine("Нажмите любую клавишу для продолжения...");
        Console.ReadKey();
    }
    
    /// <summary>
    /// Выводит текст в консоль с эффектом печатания.
    /// </summary>
    /// <param name="text">Текст, который необходимо вывести.</param>
    private static void TypeText(string text)
    {
        foreach (char symbol in text)
        {
            Console.Write(symbol);
            Thread.Sleep(15);
        }
        Console.WriteLine();
    }
}