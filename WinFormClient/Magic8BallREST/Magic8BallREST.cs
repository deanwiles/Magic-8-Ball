using RestSharp;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Magic8BallREST
{
    /// <summary>
    /// Magic 8 Ball Question and Answer
    /// </summary>
    public class Magic
    {
        /// <summary>
        /// Question asked of Magic 8 Ball
        /// </summary>
        public string Question { get; set; }
        /// <summary>
        /// Answer from Magic 8 Ball
        /// </summary>
        public string Answer { get; set; }
        /// <summary>
        /// Type of Magic 8 Ball Answer
        /// </summary>
        public string Type { get; set; }
    }

    class Magic8BallApi
    {
        const string BaseUrl = "https://8ball.delegator.com/magic";

        readonly IRestClient _client;

        readonly DataFormat _dataFormat;

        public Magic8BallApi(DataFormat Format)
        {
            _client = new RestClient(BaseUrl);
            _dataFormat = Format;
        }

#if (true)
        public T Execute<T>(RestRequest request) where T : new()
        {
            request.AddParameter("Format", _dataFormat.ToString("G"), ParameterType.UrlSegment); // used on every request

            Utils.LogMsg($"Magic8Ball {request.Method:G} {_client.BuildUri(request)}");

            var response = _client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var magic8Exception = new ApplicationException(message, response.ErrorException);
                throw magic8Exception;
            }

            Utils.LogMsg($"Magic8Ball response: {Environment.NewLine}{response.Content}");

            return response.Data;
        }

        public Magic GetMagic(string Question)
        {
            var request = new RestRequest()
            {
                Resource = "{Format}/{Question}",
                RequestFormat = _dataFormat,
                RootElement = "magic"
            };

            request.AddParameter("Question", Question, ParameterType.UrlSegment);

            return Execute<Magic>(request);
        }
#endif
    }

    /// <summary>
    /// Type of Magic 8 Ball Answer
    /// </summary>
    [ComVisible(true)]
    [Description("Type of Magic 8 Ball Answer")]
    public enum AnswerType
    {
        /// <summary>
        /// Contrary/Negative Answer
        /// </summary>
        [Description("Contrary/Negative Answer")]
        Contrary = -1,
        /// <summary>
        /// Neutral/Non-committal Answer
        /// </summary>
        [Description("Neutral/Non-committal Answer")]
        Neutral = 0,
        /// <summary>
        /// Affirmative/Positive Answer
        /// </summary>
        [Description("Affirmative/Positive Answer")]
        Affirmative = 1,
    }

    /// <summary>
    /// COM Interface for Magic 8 Ball RESTful web service
    /// </summary>
    [ComVisible(true)]
    [Description("Magic 8 Ball Interface")]
    public interface IMagic8Ball
    {
        /// <summary>
        /// Ask the Magic 8 Ball a Question
        /// </summary>
        /// <param name="Question">Yes/No question to ask</param>
        /// <returns>The Magic 8 Ball answer</returns>
        [Description("Ask the Magic 8 Ball a Question")]
        string Ask(string Question);

        /// <summary>
        /// Question asked of Magic 8 Ball
        /// </summary>
        string Question { [Description("Question asked of Magic 8 Ball")] get; }

        /// <summary>
        /// Answer from Magic 8 Ball
        /// </summary>
        string Answer { [Description("Answer from Magic 8 Ball")] get; }

        /// <summary>
        /// Type of Magic 8 Ball Answer
        /// </summary>
        AnswerType Type { [Description("Type of Magic 8 Ball Answer")] get; }
    }

    /// <summary>
    /// COM Callable Wrapper for for Magic 8 Ball RESTful web service
    /// </summary>
    /// <remarks>
    /// This class only supports late binding for COM clients
    /// </remarks>
    [ComVisible(true)]
    [ProgId("MESample.Magic8Ball")]
    [Description("Magic 8 Ball Class")]
    [ClassInterface(ClassInterfaceType.None)]
    public class Magic8Ball : IMagic8Ball
    {
        private Magic _magic = new();

        /// <summary>
        /// Create instance of Magic8Ball class
        /// </summary>
        // NOTE: Default constructor is required for COM components
        public Magic8Ball()
        {
        }

        /// <summary>
        /// Ask the Magic 8 Ball a Question
        /// </summary>
        /// <param name="Question">Yes/No question to ask</param>
        /// <returns>The Magic 8 Ball answer</returns>
        public string Ask(string Question)
        {
            // Catch and log any errors
            try
            {
                // Create Magic 8 Ball Api instance using JSON
                var api = new Magic8BallApi(DataFormat.Json);
                // Ask the specified question and return the answer
                _magic = api.GetMagic(Question);
                return Answer;
            }
            catch (Exception eek)
            {
                Utils.LogErr(eek, $"Failed asking the Magic 8 Ball '{Question}'");
                throw;  // Rethrow the error back to RT
            }
        }

        /// <summary>
        /// Question asked of Magic 8 Ball
        /// </summary>
        public string Question { get { return _magic.Question; } }

        /// <summary>
        /// Answer from Magic 8 Ball
        /// </summary>
        public string Answer { get { return _magic.Answer; } }

        /// <summary>
        /// Type of Magic 8 Ball Answer
        /// </summary>
        public AnswerType Type
        {
            get
            {
                var type = (_magic.Type?.ToLower()) switch
                {
                    "negative" or "contrary" => AnswerType.Contrary,
                    "affirmative" or "positive" => AnswerType.Affirmative,
                    _ => AnswerType.Neutral,
                };
                return type;
            }
        }
    }
}
