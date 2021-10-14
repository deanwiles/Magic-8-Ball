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
        public InnerMagic Magic { get; set; }
    }

    /// <summary>
    /// Magic 8 Ball Question and Answer class
    /// </summary>
    /// <remarks>
    /// This class represents the inner JSON object in the MagicResponse class
    /// </remarks>
    public class InnerMagic
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
        [JsonIgnore]
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

    public class DelegatorMagic8Ball : Magic8BallData, IMagic8BallService
    {
        const string BaseUrl = "https://8ball.delegator.com/magic";

        private static readonly HttpClient _client = new();

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
                // Send HHTP GET request and parse JSON response
                // NOTE: If no question, an error will occur, which will demonstrate inner exception handling
                string url = Uri.EscapeUriString($"{BaseUrl}/json/{Question}");
                var magicResponse = await _client.GetFromJsonAsync<MagicResponse>(url);
                // Save question, answer and type
                this.Question = Question;
                Type = magicResponse.Magic.Type;
                Answer = magicResponse.Magic.Answer;
                // Return this Magic 8 Ball object with resulting Question, Answer and Type
                return this;
            }
            catch (Exception ex)
            {
                // Wrap and rethrow the error back to caller with some context
                throw new Exception($"Failed asking the Magic 8 Ball '{Question}'.", ex);
            }
        }
    }
}
