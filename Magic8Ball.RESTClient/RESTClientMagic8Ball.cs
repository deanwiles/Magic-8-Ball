﻿using Magic8Ball.Shared;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Magic8Ball.RESTClient;

/// <summary>
/// Magic 8 Ball Question and Answer Response class
/// </summary>
/// <remarks>
/// This class represents the JSON object returned from a HTTP GET call to
/// https://dwmagic8ball.azurewebsites.net/api/ask?question={question}
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
    // Default to Production Base Url for Magic 8 Ball API
    private readonly string BaseUrl;

    private static readonly HttpClient _client = new();

    /// <summary>
    /// Construct RESTClientMagic8Ball with Default Base Url for Magic 8 Ball API
    /// </summary>
    public RESTClientMagic8Ball()
    {
        // TODO: Check for way to identify Dev/Test vs Prod
        // Use Default Base Url for Magic 8 Ball API
        //this.BaseUrl = "https://dwmagic8ball.azurewebsites.net/api";
        this.BaseUrl = "https://dwmagic8balltest.azurewebsites.net/api";
    }

    /// <summary>
    /// Construct RESTClientMagic8Ball with specified Base Url for Magic 8 Ball API
    /// </summary>
    /// <param name="BaseUrl">Base Url for Magic 8 Ball API</param>
    /// <exception cref="ArgumentException">Base Url for Magic 8 Ball API is not well-formed</exception>
    public RESTClientMagic8Ball(string BaseUrl)
    {
        // Verify that Url is well-formed
        if (!Uri.IsWellFormedUriString(BaseUrl, UriKind.Absolute))
            throw new ArgumentException($"Base Url for Magic 8 Ball API is not well-formed: '{BaseUrl}'", nameof(BaseUrl));
        // Save specified Base Url for Magic 8 Ball API
        this.BaseUrl = BaseUrl;
    }

    /// <summary>
    /// Ask the Classic Magic 8 Ball a Question
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
            string url = $"{BaseUrl}/ask?question={Uri.EscapeDataString(Question)}";
            var magicResponse = await _client.GetFromJsonAsync<MagicResponse>(url, new JsonSerializerOptions(JsonSerializerDefaults.Web)) 
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

    /// <summary>
    /// Ask the Artificially Intelligent Magic 8 Ball a Question
    /// </summary>
    /// <param name="Question">Yes/No question to ask</param>
    /// <returns>This Magic 8 Ball object with resulting Question, Answer and Type</returns>
    public async Task<Magic8BallData> AskAIAsync(string Question)
    {
        // Catch and log any errors
        try
        {
            // Send HTTP GET request and parse JSON response
            // NOTE: If no question, an error may occur, which will demonstrate inner exception handling
            string url = $"{BaseUrl}/askai?question={Uri.EscapeDataString(Question)}";
            var magicResponse = await _client.GetFromJsonAsync<MagicResponse>(url, new JsonSerializerOptions(JsonSerializerDefaults.Web))
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
