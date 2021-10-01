using Magic8Ball.Shared;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Magic8Ball.Delegator
{
    /// <summary>
    /// Magic 8 Ball Response class
    /// </summary>
    /// <remarks>
    /// This class represents the JSON object returned from a HTTP GET call to
    /// https://8ball.delegator.com/magic/json/{question}
    /// </remarks>
    public class MagicResponse
    {
        /// <summary>
        /// Magic 8 Ball Question and Answer class
        /// </summary>
        /// <remarks>
        /// This class represents the JSON object returned from a HTTP GET call to
        /// https://8ball.delegator.com/magic/json/{question}
        /// </remarks>
        [JsonPropertyName("magic")]
        public Magic Magic { get; set; }
    }

    /// <summary>
    /// Magic 8 Ball Question and Answer class
    /// </summary>
    /// <remarks>
    /// This class represents the inner JSON object in the MagicResponse class
    /// </remarks>
    public class Magic
    {
        /// <summary>
        /// Question asked of Magic 8 Ball
        /// </summary>
        [JsonPropertyName("question")]
        public string Question { get; set; }
        /// <summary>
        /// Answer from Magic 8 Ball
        /// </summary>
        [JsonPropertyName("answer")]
        public string Answer { get; set; }
        /// <summary>
        /// Type of Magic 8 Ball Answer (as string)
        /// </summary>
        [JsonPropertyName("type")]
        public string TypeName { get; set; }
        /// <summary>
        /// Type of Magic 8 Ball Answer
        /// </summary>
        public AnswerType Type
        {
            get
            {
                var type = (TypeName.ToLower()) switch
                {
                    "negative" or "contrary" => AnswerType.Negative,
                    "affirmative" or "positive" => AnswerType.Positive,
                    _ => AnswerType.Neutral,
                };
                return type;
            }
        }

    }


    public class DelegatorMagic8Ball : Magic8BallBase
    {
        const string BaseUrl = "https://8ball.delegator.com/magic";

        private static readonly HttpClient _client = new();

        /// <summary>
        /// Ask the Magic 8-Ball a Question
        /// </summary>
        /// <param name="Question">Yes/No question to ask</param>
        /// <returns>The Magic 8-Ball answer</returns>
        public override async Task<string> AskAsync(string Question)
        {
            // Catch and log any errors
            try
            {
                // If no question, force an error using an invalid url to demonstrate inner exception handling
                if (string.IsNullOrWhiteSpace(Question))
                    Question = @"..\..\";
                // Send HHTP GET request and parse JSON response
                string url = $"{BaseUrl}/{Question}";
                var magicResponse = await _client.GetFromJsonAsync<MagicResponse>(url);
                // Save question, answer and type
                this.Question = Question;
                Type = magicResponse.Magic.Type;
                Answer = magicResponse.Magic.Answer;
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
