namespace Tainobor.Test;

/// <summary>
/// Представляет вопрос теста и список вариантов ответа. 
/// </summary>
public class Question
{
    public required string Text { get; init; }
    public required List<Answer> Answers { get; init; }
}