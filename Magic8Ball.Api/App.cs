using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;

namespace Magic8Ball.Api;

public class App
{
    private readonly ILogger<App> _logger;

    public App(ILogger<App> log)
    {
        _logger = log;
    }

    [FunctionName("App")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous)] HttpRequest request)
    {
        _logger.LogInformation("C# HTTP trigger function processing an 'App' request...");

        // Redirect to Magic 8 Ball Azure Static Web App
        string setting = Environment.UserInteractive ? "MAGIC8BALL_WEBAPP_URL_DEV" : "MAGIC8BALL_WEBAPP_URL";
        string? Url = Environment.GetEnvironmentVariable(setting);
        if (Url == null)
        {
            _logger.LogInformation($"Error: Missing environment variable \"{setting}\"");
            return new NotFoundResult();
        }
        _logger.LogInformation($"Redirecting to Url = \"{Url}\"...");
        return new RedirectResult(Url);
    }
}
