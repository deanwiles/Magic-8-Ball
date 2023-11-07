using Magic8Ball.Shared;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Magic8Ball.RESTClient;

/// <summary>
/// Type of Magic 8 Ball REST Service Request
/// </summary>
public enum ServiceType
{
    /// <summary>
    /// Classic Magic 8 Ball Service
    /// </summary>
    Classic = 0,
    /// <summary>
    /// Artificially Intelligent Magic 8 Ball Service
    /// </summary>
    AI = 1
}

/// <summary>
/// Magic 8 Ball Question and Answer Response class
/// </summary>
/// <remarks>
/// This class represents the JSON object returned from a HTTP GET call to
/// https://jolly-water-0879a521e.3.azurestaticapps.net/api/ask?question={question}
/// </remarks>
public class MagicResponse
{
    /// <summary>
    /// Question asked of Magic 8 Ball
    /// </summary>
    [JsonPropertyName("question")]
    public string Question { get; set; } = string.Empty;
    /// <summary>
    /// Answer from Magic 8 Ball
    /// </summary>
    [JsonPropertyName("answer")]
    public string Answer { get; set; } = string.Empty;
    /// <summary>
    /// Type of Magic 8 Ball Answer (as string)
    /// </summary>
    [JsonPropertyName("type")]
    public string TypeName { get; set; } = string.Empty;
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
    // Static HttpClient used for all requests
    private static readonly HttpClient _client = new();

    // Base Address Uri for Magic 8 Ball API
    private readonly Uri BaseAddress;

    // Magic 8 Ball Service Type
    private readonly ServiceType ServiceType;

    /// <summary>
    /// Construct RESTClientMagic8Ball with Default Base Address Uri and Classic Service for Magic 8 Ball API
    /// </summary>
    public RESTClientMagic8Ball()
    {
        this.BaseAddress = new Uri("https://jolly-water-0879a521e.3.azurestaticapps.net");
        this.ServiceType = ServiceType.Classic;
    }

    /// <summary>
    /// Construct RESTClientMagic8Ball with specified Base Address Uri and Service Type for Magic 8 Ball API
    /// </summary>
    /// <param name="BaseAddress">Base Address Uri for Magic 8 Ball API</param>
    /// <param name="ServiceType">Magic 8 Ball Service Type</param>
    /// <exception cref="UriFormatException">Base Address Uri for Magic 8 Ball API is not well-formed</exception>
    public RESTClientMagic8Ball(string BaseAddress, ServiceType ServiceType /*= ServiceType.Classic*/)
    {
        // Save specified Base Address Uri and Service Type for Magic 8 Ball API
        this.BaseAddress = new Uri(BaseAddress);
        this.ServiceType = ServiceType;
    }

    /// <summary>
    /// Ask the Magic 8 Ball a Question
    /// </summary>
    /// <param name="Question">Yes/No question to ask</param>
    /// <returns>This Magic 8 Ball object with resulting Question, Answer and Type</returns>
    /// <remarks><see cref="ServiceType"/>determines whether the Classic or Artificially Intelligent API function is used</remarks>
    public async Task<Magic8BallData> AskAsync(string Question)
    {
        // Catch and log any errors
        try
        {
            // Send HTTP GET request and parse JSON response
            // NOTE: If no question, an error may occur, which will demonstrate inner exception handling
            string func = ServiceType == ServiceType.Classic ? "ask" : "askai";
            Uri uri = new(BaseAddress, $"api/{func}?question={Uri.EscapeDataString(Question)}");
            var magicResponse = await _client.GetFromJsonAsync<MagicResponse>(uri, new JsonSerializerOptions(JsonSerializerDefaults.Web)) 
                ?? throw new Exception("No Magic 8 Ball response received");
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
