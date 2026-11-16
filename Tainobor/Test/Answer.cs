using System.Collections.Generic;

namespace Tainobor.Test;

/// <summary>
/// Представляет вариант ответа на вопрос теста и связанные с ним эффекты.
/// </summary>
public class Answer(string text, List<Effect> effects, int score = 0)
{
    public string AnswerText { get; init; } = text;
    public List<Effect> AnswerEffects { get; init; } =  effects;
    public int Score { get; init; } = score;
}