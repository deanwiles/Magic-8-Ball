namespace Magic8Ball.Shared;

/// <summary>
/// Type of Magic 8 Ball Answer
/// </summary>
public enum AnswerType
{
    /// <summary>
    /// Negative / Contrary Answer
    /// </summary>
    Negative = -1,
    /// <summary>
    /// Neutral / Non-committal Answer
    /// </summary>
    Neutral = 0,
    /// <summary>
    /// Positive / Affirmative Answer
    /// </summary>
    Positive = 1,
}

/// <summary>
/// Magic 8 Ball Answer
/// </summary>
public class MagicAnswer
{
    /// <summary>
    /// Answer from Magic 8 Ball
    /// </summary>
    public string Answer { get; set; } = string.Empty;

    /// <summary>
    /// Type of Magic 8 Ball Answer
    /// </summary>
    /// <remarks>
    /// Default type is Neutral
    /// </remarks>
    public AnswerType Type { get; set; } = AnswerType.Neutral;

    /// <summary>
    /// Magic 8 Ball Answer Default Constructor
    /// </summary>
    public MagicAnswer()
    {
    }

    /// <summary>
    /// Magic 8 Ball Answer Constructor with Values
    /// </summary>
    /// <param name="Type">Type of Magic 8 Ball Answer</param>
    /// <param name="Answer">Answer from Magic 8 Ball</param>
    public MagicAnswer(AnswerType Type, string Answer)
    {
        // Save Answer and Type
        this.Type = Type;
        this.Answer = Answer;
    }
}

/// <summary>
/// Magic 8 Ball Question and Answer base class
/// </summary>
public abstract class Magic8BallData : MagicAnswer
{
    /// <summary>
    /// Question asked of Magic 8 Ball
    /// </summary>
    public string Question { get; set; } = string.Empty;

    /// <summary>
    /// Magic 8 Ball Question and Answer Default Constructor
    /// </summary>
    public Magic8BallData() : base()
    {
    }

    /// <summary>
    /// Magic 8 Ball Question and Answer Constructor with Values
    /// </summary>
    /// <param name="Question">Yes/No question to ask</param>
    /// <param name="Answer">Answer from Magic 8 Ball</param>
    /// <param name="Type">Type of Magic 8 Ball Answer</param>
    public Magic8BallData(string Question, string Answer, AnswerType Type) : base(Type, Answer)
    {
        // Also save Question
        this.Question = Question;
    }
}
