using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace Magic8Ball.Api;

public class App(ILogger<App> log)
{
    [Function("App")]
    public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous)] HttpRequestData request)
    {
        log.LogInformation("C# HTTP trigger function processing an 'App' request...");

        // Redirect to Magic 8 Ball Azure Static Web App
        var response = request.CreateResponse();
        string setting = Environment.UserInteractive ? "MAGIC8BALL_WEBAPP_URL_DEV" : "MAGIC8BALL_WEBAPP_URL";
        string? Url = Environment.GetEnvironmentVariable(setting);
        if (Url == null)
        {
            log.LogInformation($"Error: Missing environment variable \"{setting}\"");
            response.StatusCode = HttpStatusCode.NotFound;
            return response;
        }
        log.LogInformation($"Redirecting to Url = \"{Url}\"...");
        response.StatusCode = HttpStatusCode.Redirect;
        response.Headers.Add("Location", Url);
        return response;
    }
}
