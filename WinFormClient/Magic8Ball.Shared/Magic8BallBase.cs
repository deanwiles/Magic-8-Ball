﻿namespace Magic8Ball.Shared
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
    /// Magic 8-Ball Question and Answer
    /// </summary>
    public class Magic8BallBase : MagicAnswer
    {
        /// <summary>
        /// Question asked of Magic 8-Ball
        /// </summary>
        public string Question { get; set; }
    }
}
