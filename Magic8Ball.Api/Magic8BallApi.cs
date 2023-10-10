using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Magic8Ball.Api;

public class Magic8BallApi
{
    private readonly ILogger<Magic8BallApi> _logger;

    public Magic8BallApi(ILogger<Magic8BallApi> log)
    {
        _logger = log;
    }

    [FunctionName("Ask")]
    [OpenApiOperation(operationId: "Ask", tags: new[] { "Magic8Ball" }, Description = "Ask the Magic 8 Ball a question")]
    [OpenApiParameter(name: "question", In = ParameterLocation.Query, Required = true, Type = typeof(string), 
        Description = "The Yes/No question to ask of the Magic 8 Ball")]
    [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", 
        bodyType: typeof(Classic.ClassicMagic8Ball), Description = "The Magic 8 Ball's response")]
    [OpenApiResponseWithBody(statusCode: HttpStatusCode.BadRequest, contentType: "text/plain", 
        bodyType: typeof(string), Description = "The error response message")]
    public async Task<IActionResult> Ask(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest request)
    {
        _logger.LogInformation("C# HTTP trigger function processed an 'Ask' request...");

        // Check for Question in GET query or in POST body
        string question = request.Query["question"];
        if (StringValues.IsNullOrEmpty(question))
        {
            string requestBody = await new StreamReader(request.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            question = data?.question;
        }
        _logger.LogInformation($"Question = \"{question}\".");

        // Ask the Classic Magic 8 Ball service the provided question
        var magic8Ball = new Classic.ClassicMagic8Ball();
        try
        {
            await magic8Ball.AskAsync(question);
            _logger.LogInformation($"Answer = \"{magic8Ball.Answer}\", Type = \"{magic8Ball.Type}\".");
        }
        catch (Exception ex)
        {
            // Return error message
            string msg = ex.Message;
            if (null != ex.InnerException) msg += $"{Environment.NewLine}{ex.InnerException.Message}";
            _logger.LogInformation($"Error = \"{msg}\".");
            return new BadRequestObjectResult(msg);
        }

        // Create JSON serializer that indents and uses camelCase property names and enumerations
        var settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() },
            Converters = { new StringEnumConverter(new CamelCaseNamingStrategy()) }
        };

        // Return Magic8Ball object as JSON
        return new JsonResult(magic8Ball, settings);
    }

    [FunctionName("AskAI")]
    [OpenApiOperation(operationId: "AskAI", tags: new[] { "Magic8Ball" }, Description = "Ask the Artificially Intelligent Magic 8 Ball a question")]
    [OpenApiParameter(name: "question", In = ParameterLocation.Query, Required = true, Type = typeof(string),
        Description = "The Yes/No question to ask of the AI Magic 8 Ball")]
    [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json",
        bodyType: typeof(AI.AIMagic8Ball), Description = "The AI Magic 8 Ball's response")]
    [OpenApiResponseWithBody(statusCode: HttpStatusCode.BadRequest, contentType: "text/plain",
        bodyType: typeof(string), Description = "The error response message")]
    public async Task<IActionResult> AskAI(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest request)
    {
        _logger.LogInformation("C# HTTP trigger function processed an 'AskAI' request...");

        // Check for Question in GET query or in POST body
        string question = request.Query["question"];
        if (StringValues.IsNullOrEmpty(question))
        {
            string requestBody = await new StreamReader(request.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            question = data?.question;
        }
        _logger.LogInformation($"Question = \"{question}\".");

        // Ask the AI Magic 8 Ball service the provided question
        var magic8Ball = new AI.AIMagic8Ball();
        try
        {
            await magic8Ball.AskAsync(question);
            _logger.LogInformation($"Answer = \"{magic8Ball.Answer}\", Type = \"{magic8Ball.Type}\".");
        }
        catch (Exception ex)
        {
            // Return error message
            string msg = ex.Message;
            if (null != ex.InnerException) msg += $"{Environment.NewLine}{ex.InnerException.Message}";
            _logger.LogInformation($"Error = \"{msg}\".");
            return new BadRequestObjectResult(msg);
        }

        // Create JSON serializer that indents and uses camelCase property names and enumerations
        var settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() },
            Converters = { new StringEnumConverter(new CamelCaseNamingStrategy()) }
        };

        // Return Magic8Ball object as JSON
        return new JsonResult(magic8Ball, settings);
    }

    [FunctionName("App")]
    public IActionResult App([HttpTrigger(AuthorizationLevel.Anonymous)] HttpRequest request)
    {
        _logger.LogInformation("C# HTTP trigger function processing an 'App' request...");

        // Redirect to Magic 8 Ball Azure Static Web App
        string Url = Environment.GetEnvironmentVariable(Environment.UserInteractive ? "MAGIC8BALL_WEBAPP_URL_DEV" : "MAGIC8BALL_WEBAPP_URL");
        _logger.LogInformation($"Redirecting to Url = \"{Url}\"...");
        return new RedirectResult(Url);
    }
}

