using Magic8Ball.Shared;
using System;
using System.Collections.Generic;

namespace Magic8Ball.Classic
{
    public class ClassicMagic8Ball : Magic8BallBase
    {
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
                // If no question, force an error to demonstrate inner exception handling
                if (string.IsNullOrWhiteSpace(Question))
                    throw new Exception("You must ask a question to get an answer!");
                // Get random answer
                int index = _random.Next(_answers.Count);
                var answer = _answers[index];
                // Save question, answer and type
                this.Question = Question;
                Type = answer.Type;
                Answer = answer.Answer;
                // Return the answer
                return Answer;
            }
            catch (Exception eek)
            {
                // Wrap and rethrow the error back to caller with some context
                throw new Exception($"Failed asking the Magic 8-Ball '{Question}'", eek);
            }
        }
    }
}
