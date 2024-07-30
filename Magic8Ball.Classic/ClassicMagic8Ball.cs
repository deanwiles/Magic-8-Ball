using Magic8Ball.Shared;
using System.Collections.ObjectModel;

namespace Magic8Ball.Classic;

/// <summary>
/// Predefined Magic 8 Ball Answers
/// </summary>
public class PredefinedMagicAnswers : ReadOnlyCollection<MagicAnswer>
{
    /// <summary>
    /// Classic Magic 8 Ball answers as listed in https://en.wikipedia.org/wiki/Magic_8-Ball
    /// </summary>
    public static readonly PredefinedMagicAnswers ClassicAnswers = new(new List<MagicAnswer>()
    {
        new(AnswerType.Negative, "Don't count on it"),
        new(AnswerType.Negative, "My reply is no"),
        new(AnswerType.Negative, "My sources say no"),
        new(AnswerType.Negative, "Outlook not so good"),
        new(AnswerType.Negative, "Very doubtful"),
        new(AnswerType.Neutral, "Ask again later"),
        new(AnswerType.Neutral, "Better not tell you now"),
        new(AnswerType.Neutral, "Cannot predict now"),
        new(AnswerType.Neutral, "Concentrate and ask again"),
        new(AnswerType.Neutral, "Reply hazy, try again"),
        new(AnswerType.Positive, "As I see it, yes"),
        new(AnswerType.Positive, "It is certain"),
        new(AnswerType.Positive, "It is decidedly so"),
        new(AnswerType.Positive, "Most likely"),
        new(AnswerType.Positive, "Outlook good"),
        new(AnswerType.Positive, "Signs point to yes"),
        new(AnswerType.Positive, "Without a doubt"),
        new(AnswerType.Positive, "Yes"),
        new(AnswerType.Positive, "Yes, definitely"),
        new(AnswerType.Positive, "You may rely on it")
    }.AsReadOnly());

    /// <summary>
    /// Construct Predefined List of MagicAnswers
    /// See <see cref="ClassicAnswers"/> for example List of MagicAnswers
    /// </summary>
    /// <param name="MagicAnswers">List of MagicAnswers</param>
    /// <exception cref="ArgumentException">List of MagicAnswers must contain at least one entry</exception>
    public PredefinedMagicAnswers(ReadOnlyCollection<MagicAnswer> MagicAnswers) : base(MagicAnswers)
    {
        // Verify there was at least one answer to work with
        if (Count < 1)
            throw new ArgumentException("List of MagicAnswers must contain at least one entry", nameof(MagicAnswers));
    }

    /// <summary>
    /// Return the PredefinedList of MagicAnswers grouped by AnswerType
    /// </summary>
    /// <returns>PredefinedList of MagicAnswers grouped by AnswerType</returns>
    public GroupedMagicAnswers ToGroupedMagicAnswers()
    {
        // Return the Predefined List of MagicAnswers grouped by AnswerType
        var gma = new GroupedMagicAnswers
        {
            Negative = this.Where(t => t.Type == AnswerType.Negative).Select(a => a.Answer).ToList<string>(),
            Neutral = this.Where(t => t.Type == AnswerType.Neutral).Select(a => a.Answer).ToList<string>(),
            Positive = this.Where(t => t.Type == AnswerType.Positive).Select(a => a.Answer).ToList<string>()
        };
        return gma;
    }
}

/// <summary>
/// Collection of Magic 8 Ball Answers grouped by AnswerType
/// </summary>
public class GroupedMagicAnswers
{
    /// <summary>
    /// Negative / Contrary Answers
    /// </summary>
    public List<string> Negative { get; set; } = [];
    /// <summary>
    /// Neutral / Non-committal Answers
    /// </summary>
    public List<string> Neutral { get; set; } = [];
    /// <summary>
    /// Positive / Affirmative Answers
    /// </summary>
    public List<string> Positive { get; set; } = [];

    /// <summary>
    /// Return the Collection of Magic 8 Ball Answers grouped by AnswerType as a Predefined List of MagicAnswers
    /// </summary>
    /// <returns>Collection of Magic 8 Ball Answers grouped by AnswerType as a Predefined List of MagicAnswers</returns>
    public PredefinedMagicAnswers ToPredefinedMagicAnswers()
    {
        // Return the Collection of Magic 8 Ball Answers grouped by AnswerType as a Predefined List of MagicAnswers
        var ma = new List<MagicAnswer>();
        foreach (var answer in Negative) ma.Add(new MagicAnswer(AnswerType.Negative, answer));
        foreach (var answer in Neutral) ma.Add(new MagicAnswer(AnswerType.Neutral, answer));
        foreach (var answer in Positive) ma.Add(new MagicAnswer(AnswerType.Positive, answer));
        return new PredefinedMagicAnswers(ma.AsReadOnly());
    }
}

/// <summary>
/// Magic 8 Ball Service with Classic Answers
/// See <see cref="ClassicAnswers"/> for List of MagicAnswers
/// </summary>
public class ClassicMagic8Ball : Magic8BallData, IMagic8BallService
{
    private readonly PredefinedMagicAnswers _answers;

    private static readonly Random _random = new();

    public ClassicMagic8Ball()
    {
        // Default to Classic List of MagicAnswers
        _answers = PredefinedMagicAnswers.ClassicAnswers;
    }

    /// <summary>
    /// Construct ClassicMagic8Ball with specified List of MagicAnswers.
    /// See <see cref="ClassicAnswers"/> for example List of MagicAnswers.
    /// </summary>
    /// <param name="MagicAnswers">List of MagicAnswers</param>
    /// <exception cref="ArgumentException">List of MagicAnswers must contain at least one entry</exception>
    public ClassicMagic8Ball(PredefinedMagicAnswers MagicAnswers)
    {
        // Verify there is at least one answer to work with
        if (MagicAnswers == null || MagicAnswers.Count < 1)
            throw new ArgumentException("List of MagicAnswers must contain at least one entry", nameof(MagicAnswers));
        // Use provided List of MagicAnswers instead of defaults
        _answers = MagicAnswers;
    }

    /// <summary>
    /// Ask the Magic 8 Ball a Question
    /// </summary>
    /// <param name="Question">Yes/No question to ask</param>
    /// <returns>This Magic 8 Ball object with resulting Question, Answer and Type</returns>
    public async Task<Magic8BallData> AskAsync(string Question)
    {
        // Catch and log any errors
        try
        {
            // If no question, force an error to demonstrate inner exception handling
            if (string.IsNullOrWhiteSpace(Question))
                throw new ArgumentException("You must ask a question to get an answer!");
            // Get random answer
            int index = _random.Next(_answers.Count);
            var answer = _answers[index];
            // Save question, answer and type
            this.Question = Question;
            Type = answer.Type;
            Answer = answer.Answer;
            // Return this Magic 8 Ball object with resulting Question, Answer and Type
            return await Task.FromResult(this);
        }
        catch (Exception ex)
        {
            // Wrap and rethrow the error back to caller with some context
            throw new Exception($"Failed asking the Magic 8 Ball '{Question}'.", ex);
        }
    }
}
