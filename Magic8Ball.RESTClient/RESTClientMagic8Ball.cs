using Magic8Ball.Shared;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Magic8Ball.RESTClient
{
    /// <summary>
    /// Magic 8 Ball Question and Answer Response class
    /// </summary>
    /// <remarks>
    /// This class represents the JSON object returned from a HTTP GET call to
    /// https://magic-8-ball.azurewebsites.net/api/ask?question={question}
    /// </remarks>
    public class MagicResponse
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
                // Parse and return Answer TypeName as AnswerType
                if (!Enum.TryParse<AnswerType>(TypeName, true, out AnswerType type))
                    type = AnswerType.Neutral;
                return type;
            }
        }

    }

    public class RESTClientMagic8Ball : Magic8BallData, IMagic8BallService
    {
        const string BaseUrl = "https://magic-8-ball.azurewebsites.net/api";

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
                // Send HTTP GET request and parse JSON response
                // NOTE: If no question, an error may occur, which will demonstrate inner exception handling
                string url = Uri.EscapeUriString($"{BaseUrl}/ask?question={Question}");
                var magicResponse = await _client.GetFromJsonAsync<MagicResponse>(url);
                // Save question, answer and type
                this.Question = Question;
                Type = magicResponse.Type;
                Answer = magicResponse.Answer;
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
