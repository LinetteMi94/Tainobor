namespace Tainobor.Test;

/// <summary>
/// Представляет вариант ответа на вопрос теста и связанные с ним эффекты.
/// </summary>
public class Answer
{
    public required string AnswerText { get; init; }
    public required List<Effect> AnswerEffects { get; init; }
}