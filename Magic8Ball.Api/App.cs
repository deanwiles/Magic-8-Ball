using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Magic8Ball.Api;

public class App(ILogger<App> logger)
{
    [Function("App")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest request)
    {
        logger.LogInformation("C# HTTP trigger function processing an 'App' request...");

        // Redirect to Magic 8 Ball Azure Static Web App
        var setting = Environment.UserInteractive ? "MAGIC8BALL_WEBAPP_URL_DEV" : "MAGIC8BALL_WEBAPP_URL";
        var url = Environment.GetEnvironmentVariable(setting);
        if (url == null)
        {
            logger.LogInformation("Error: Missing environment variable \"{Setting}\"", setting);
            return new NotFoundResult();
        }
        logger.LogInformation("Redirecting to url = \"{Url}\"...", url);
        return new RedirectResult(url);
    }
}
