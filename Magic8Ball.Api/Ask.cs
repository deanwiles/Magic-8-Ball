using Magic8Ball.Classic;
using Magic8Ball.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Magic8Ball.Api;

public class Ask(ILogger<Ask> logger)
{
    [Function("Ask")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest request)
    {
        logger.LogInformation("C# HTTP trigger function processed an 'Ask' request...");

        // Check for Question in GET query or in POST body
        string? question = request.Query["question"];
        if (string.IsNullOrWhiteSpace(question))
        {
            string requestBody = await new StreamReader(request.Body).ReadToEndAsync();
            if (!string.IsNullOrWhiteSpace(requestBody))
            {
                dynamic? data = JsonSerializer.Deserialize<dynamic>(requestBody);
                question = data?.question;
            }
        }
        logger.LogInformation("Question = \"{Question}\"", question);

        // Ask the Classic Magic 8 Ball service the provided question
        var magic8Ball = new ClassicMagic8Ball();
        try
        {
            if (string.IsNullOrWhiteSpace(question))
                throw new Exception("The Magic 8 Ball can only provide an Answer when a Question is asked.");
            await magic8Ball.AskAsync(question);
            logger.LogInformation("Answer = \"{Answer}\"", magic8Ball.Answer);
            logger.LogInformation("Type = \"{Type}\"", magic8Ball.Type);
        }
        catch (Exception ex)
        {
            // Return error message
            string msg = ex.Message;
            if (null != ex.InnerException) msg += $"{Environment.NewLine}{ex.InnerException.Message}";
            logger.LogInformation("Error = \"{Error}\"", msg);
            return new BadRequestObjectResult(msg);
        }

        // Create JSON serializer that indents and uses camelCase property names and enumerations
        var settings = new JsonSerializerOptions()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
        };

        // Return Magic8Ball object as JSON
        return new JsonResult(magic8Ball as Magic8BallData, settings);
    }
}
