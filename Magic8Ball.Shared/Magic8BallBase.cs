using System.Threading.Tasks;

namespace Magic8Ball.Shared
{
    /// <summary>
    /// Type of Magic 8-Ball Answer
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
    /// Magic 8-Ball Question and Answer base class
    /// </summary>
    public abstract class Magic8BallBase : MagicAnswer
    {
        /// <summary>
        /// Question asked of Magic 8-Ball
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// Magic 8-Ball Question and Answer Default Constructor
        /// </summary>
        public Magic8BallBase()
        {
            // Default answer is non-committal
            Answer = "I don't know how to answer that :(";
            Type = AnswerType.Neutral;
        }

        /// <summary>
        /// Magic 8-Ball Question and Answer Constructor with Values
        /// </summary>
        /// <param name="Question">Yes/No question to ask</param>
        /// <param name="Answer">Answer from Magic 8-Ball</param>
        /// <param name="Type">Type of Magic 8-Ball Answer</param>
        public Magic8BallBase(string Question, string Answer, AnswerType Type) : base(Type, Answer)
        {
            // Also save Question
            this.Question = Question;
        }

        /// <summary>
        /// Ask the Magic 8-Ball a Question
        /// </summary>
        /// <param name="Question">Yes/No question to ask</param>
        /// <returns>The Magic 8-Ball answer</returns>
        public virtual async Task<string> AskAsync(string Question)
        {
            // Save question
            this.Question = Question;
            // Return the default answer
            return await Task.FromResult(Answer);
        }
    }
}
