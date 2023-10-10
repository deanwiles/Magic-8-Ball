using Google.Ai.Generativelanguage.V1Beta2;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Magic8Ball.Shared;

namespace Magic8Ball.AIClient;

public class AIClientMagic8Ball : Magic8BallData, IMagic8BallService
{
    private static readonly string _negativePrompt = "negative";
    private static readonly string _neutralPrompt = "neutral";
    private static readonly string _positivePrompt = "positive, committed";

    private static readonly List<string> _negativeTones = new() { "empathetic", "apologetic", "disappointed" };
    private static readonly List<string> _neutralTones = new() { "wishy-washy", "apathetic", "sanguine" };
    private static readonly List<string> _positiveTones = new() { "happy", "ecstatic", "optimistic" };
    // private static readonly List<string> _invalidTones = new() { "witty", "surprised", "sarcastic" };

    private static readonly Random _random = new();

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

            string promptText = $"provide a {promptType}﻿ contextual response, speaking as a friend in ﻿﻿{tone}﻿ tone, to the question \"﻿{Question}\"";

            // Get PaLM API key
            // TODO: move the API key to a private location
            var apiKey = "AIzaSyBNvpP3kciiZd0bmSoTT8zm-x4wa5Z1c54";
            var callSettings = CallSettings.FromHeader("x-goog-api-key", apiKey);

            // Setup Text service call
            var textServiceClientBuilder = new TextServiceClientBuilder()
            {
                GoogleCredential = GoogleCredential.FromAccessToken(null),
                Settings = new TextServiceSettings()
                {
                    CallSettings = callSettings,
                }
            };

            var textServiceClient = textServiceClientBuilder.Build();

            var textPrompt = new TextPrompt 
            { 
                Text = promptText 
            };

            var textRequest = new GenerateTextRequest
            {
                ModelAsModelName = ModelName.FromModel("text-bison-001"),
                Prompt = textPrompt,
                Temperature = 0.7F,
                TopK = 40, 
                TopP = 0.95F,
                CandidateCount = 1,
                MaxOutputTokens = 80
                // TODO: Add SafetySettings
                // [{'category':'HARM_CATEGORY_DEROGATORY','threshold':1},{'category':'HARM_CATEGORY_TOXICITY','threshold':1{'category':'HARM_CATEGORY_VIOLENCE','threshold':1},{'category':'HARM_CATEGORY_SEXUAL','threshold':2},{'category':'HARM_CATEGORY_MEDICAL','threshold':2},{'category':'HARM_CATEGORY_DANGEROUS','threshold':1}]
            };

            // Generate contextual and toned answer text
            GenerateTextResponse textResponse = await textServiceClient.GenerateTextAsync(textRequest);

            // Save question, answer and type
            this.Question = Question;
            Type = magic8Ball.Type;
            Answer = textResponse.Candidates[0].Output.Trim('"');

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
