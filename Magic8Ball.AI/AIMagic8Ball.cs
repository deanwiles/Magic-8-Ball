using Magic8Ball.Shared;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace Magic8Ball.AI;

public class AIMagic8Ball : Magic8BallData, IMagic8BallService
{
    private static readonly string _negativePrompt = "negative";
    private static readonly string _neutralPrompt = "neutral";
    private static readonly string _positivePrompt = "positive, committed";

    private static readonly List<string> _negativeTones = ["empathetic", "apologetic", "disappointed"];
    private static readonly List<string> _neutralTones = ["wishy-washy", "apathetic", "sanguine"];
    private static readonly List<string> _positiveTones = ["happy", "ecstatic", "optimistic"];
    // private static readonly List<string> _invalidTones = ["witty", "surprised", "sarcastic"];

    private static readonly Random _random = new();
    
    private readonly IConfiguration? _configuration;

    public AIMagic8Ball()
    {
    }

    public AIMagic8Ball(IConfiguration configuration)
    {
        _configuration = configuration;
    }

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
            // Generative Pre-Trained (GPT) Large Language Models (LLMs) are
            // typically trained and/or configured to NOT give definitive Yes or No answers,
            // so use the Classic Magic 8 Ball to get the answer type
            // and use AI to give the contextual and toned answer text
            var magic8Ball = new Classic.ClassicMagic8Ball();
            try
            {
                await magic8Ball.AskAsync(Question);
            }
            catch (Exception ex)
            {
                // Wrap and rethrow the error back to caller with some context
                throw new Exception($"Failed asking the Magic 8 Ball '{Question}'.", ex);
            }

            // Set the AI Prompt type and tone based on Classic answer type
            string promptType;
            List<string> tones;
            switch (magic8Ball.Type)
            {
                case AnswerType.Negative:
                    promptType = _negativePrompt;
                    tones = _negativeTones;
                    break;
                case AnswerType.Neutral:
                    promptType = _neutralPrompt;
                    tones = _neutralTones;
                    break;
                case AnswerType.Positive:
                    promptType = _positivePrompt;
                    tones = _positiveTones;
                    break;
                default:
                    throw new Exception($"Unexpected Magic 8 Ball Answer Type'{magic8Ball.Type}'.");
            }
            // Get random tone
            var tone = tones[_random.Next(tones.Count)];

            string promptText = $"Provide a {promptType}﻿ contextual response in five or less sentences, " +
                $"speaking as a friend in ﻿﻿{tone}﻿ tone, to the question \"﻿{Question}\"";

            // Get Gemini API key
            string setting = "Magic8Ball_Gemini_API_Key";
            string? apiKey = Environment.GetEnvironmentVariable(setting);
            if (string.IsNullOrEmpty(apiKey))
                throw new Exception($"Error: Missing environment variable \"{setting}\"");

            // Get model and base URL from configuration or environment variables
            string model = GetConfigValue("Gemini_Model") ?? "gemini-2.5-flash-lite";
            string baseUrl = GetConfigValue("Gemini_BaseUrl") ?? "https://generativelanguage.googleapis.com/v1beta";
            string endpoint = $"{baseUrl}/models/{model}:generateContent";

            using var http = new HttpClient();
            http.DefaultRequestHeaders.Add("x-goog-api-key", apiKey);

            var payload = new
            {
                contents = new []
                {
                    new
                    {
                        parts = new[] { new { text = promptText } }
                    }
                },
                generationConfig = new
                {
                    temperature = 0.7,
                    topK = 40,
                    topP = 0.95,
                    maxOutputTokens = 128,
                    candidateCount = 1
                }
            };

            var httpResponse = await http.PostAsJsonAsync(endpoint, payload);
            if (!httpResponse.IsSuccessStatusCode)
            {
                var err = await httpResponse.Content.ReadAsStringAsync();
                throw new Exception($"Gemini API request failed: {httpResponse.StatusCode} - {err}");
            }

            using var stream = await httpResponse.Content.ReadAsStreamAsync();
            using var doc = await JsonDocument.ParseAsync(stream);
            // Expecting JSON like: { "candidates": [ { "content": { "parts": [ { "text": "..." } ] } } ] }
            string output = string.Empty;
            if (doc.RootElement.TryGetProperty("candidates", out var candidates) && candidates.GetArrayLength() > 0)
            {
                var first = candidates[0];
                if (first.TryGetProperty("content", out var content) &&
                    content.TryGetProperty("parts", out var parts) && parts.GetArrayLength() > 0)
                {
                    var firstPart = parts[0];
                    if (firstPart.TryGetProperty("text", out var textProp))
                        output = textProp.GetString() ?? string.Empty;
                }
            }

            if (string.IsNullOrEmpty(output))
                throw new Exception("Gemini API returned no output.");

            // Save question, answer and type
            this.Question = Question;
            Type = magic8Ball.Type;
            Answer = output.Trim('"', '\n', '\r', ' ');

            // Return this Magic 8 Ball object with resulting Question, Answer and Type
            return this;
        }
        catch (Exception ex)
        {
            // Wrap and rethrow the error back to caller with some context
            throw new Exception($"Failed asking the Magic 8 Ball '{Question}'.", ex);
        }
    }

    private string? GetConfigValue(string key)
    {
        // Try configuration first (if provided via DI)
        if (_configuration != null)
        {
            var value = _configuration[key];
            if (!string.IsNullOrEmpty(value))
                return value;
        }

        // Fall back to environment variables
        return Environment.GetEnvironmentVariable(key);
    }
}
