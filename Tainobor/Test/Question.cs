using System.Collections.Generic;

namespace Tainobor.Test;

/// <summary>
/// Представляет вопрос теста и список вариантов ответа. 
/// </summary>
public class Question(string text,  List<Answer> answers)
{
    public string Text { get; init; } = text;
    public List<Answer> Answers { get; init; } = answers;
}