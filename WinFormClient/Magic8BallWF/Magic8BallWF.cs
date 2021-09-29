using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Magic8BallWF
{
    /// <summary>
    /// Type of Magic 8-Ball Answer
    /// </summary>
    public enum AnswerType
    {
        /// <summary>
        /// Negative / Contrary Answer
        /// </summary>
        [Description("Negative / Contrary Answer")]
        Negative = -1,
        /// <summary>
        /// Neutral / Non-committal Answer
        /// </summary>
        [Description("Neutral / Non-committal Answer")]
        Neutral = 0,
        /// <summary>
        /// Positive / Affirmative Answer
        /// </summary>
        [Description("Positive / Affirmative Answer")]
        Positive = 1,
    }

    /// <summary>
    /// Magic 8-Ball Answer
    /// </summary>
    public class MagicAnswer
    {
        /// <summary>
        /// Type of Magic 8-Ball Answer
        /// </summary>
        public AnswerType Type { get; set; }

        /// <summary>
        /// Answer from Magic 8-Ball
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// Magic 8-Ball Answer Default Constructor
        /// </summary>
        public MagicAnswer()
        {
            // Default type is Neutral
            this.Type = AnswerType.Neutral;
        }

        /// <summary>
        /// Magic 8-Ball Answer Constructor with Values
        /// </summary>
        /// <param name="Type">Type of Magic 8-Ball Answer</param>
        /// <param name="Answer">Answer from Magic 8-Ball</param>
        public MagicAnswer(AnswerType Type, string Answer)
        {
            // Save Answer and Type
            this.Type = Type;
            this.Answer = Answer;
        }
    }

    /// <summary>
    /// Magic 8-Ball Question and Answer
    /// </summary>
    public class Magic : MagicAnswer
    {
        /// <summary>
        /// Question asked of Magic 8-Ball
        /// </summary>
        public string Question { get; set; }
    }

    /// <summary>
    /// Magic 8-Ball service
    /// </summary>
    public class Magic8Ball
    {
        private Magic _magic = new();

        // Classic Magic 8-Ball answers as listed in https://en.wikipedia.org/wiki/Magic_8-Ball
        private readonly List<MagicAnswer> _answers = new()
        {
            new MagicAnswer(AnswerType.Negative, "Don't count on it"),
            new MagicAnswer(AnswerType.Negative, "My reply is no"),
            new MagicAnswer(AnswerType.Negative, "My sources say no"),
            new MagicAnswer(AnswerType.Negative, "Outlook not so good"),
            new MagicAnswer(AnswerType.Negative, "Very doubtful"),
            new MagicAnswer(AnswerType.Neutral, "Ask again later"),
            new MagicAnswer(AnswerType.Neutral, "Better not tell you now"),
            new MagicAnswer(AnswerType.Neutral, "Cannot predict now"),
            new MagicAnswer(AnswerType.Neutral, "Concentrate and ask again"),
            new MagicAnswer(AnswerType.Neutral, "Reply hazy, try again"),
            new MagicAnswer(AnswerType.Positive, "As I see it, yes"),
            new MagicAnswer(AnswerType.Positive, "It is certain"),
            new MagicAnswer(AnswerType.Positive, "It is decidedly so"),
            new MagicAnswer(AnswerType.Positive, "Most likely"),
            new MagicAnswer(AnswerType.Positive, "Outlook good"),
            new MagicAnswer(AnswerType.Positive, "Signs point to yes"),
            new MagicAnswer(AnswerType.Positive, "Without a doubt"),
            new MagicAnswer(AnswerType.Positive, "Yes"),
            new MagicAnswer(AnswerType.Positive, "Yes – definitely"),
            new MagicAnswer(AnswerType.Positive, "You may rely on it")
        };

        private readonly Random _random = new();

        /// <summary>
        /// Ask the Magic 8-Ball a Question
        /// </summary>
        /// <param name="Question">Yes/No question to ask</param>
        /// <returns>The Magic 8-Ball answer</returns>
        public string Ask(string Question)
        {
            // Catch and log any errors
            try
            {
                // Get random answer
                int index = _random.Next(_answers.Count);
                var answer = _answers[index];
                // Save question, answer and type
                _magic = new Magic() { Question = Question, Type = answer.Type, Answer = answer.Answer };
                // Return the answer
                return Answer;
            }
            catch (Exception eek)
            {
                Utils.LogErr(eek, $"Failed asking the Magic 8-Ball '{Question}'");
                throw;  // Rethrow the error back to caller
            }
        }

        /// <summary>
        /// Question asked of Magic 8-Ball
        /// </summary>
        public string Question { get => _magic.Question; }

        /// <summary>
        /// Answer from Magic 8-Ball
        /// </summary>
        public string Answer { get => _magic.Answer; }

        /// <summary>
        /// Type of Magic 8-Ball Answer
        /// </summary>
        public AnswerType Type { get => _magic.Type; }
    }
}
