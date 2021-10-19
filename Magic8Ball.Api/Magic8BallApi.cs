using Azure.Core.Serialization;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Magic8Ball.Api
{
    public static class Magic8BallApi
    {
        [Function("Ask")]
        public static async Task<HttpResponseData> Ask([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("Ask");
            logger.LogInformation("C# HTTP trigger function processing an 'Ask' request...");

            // Check for Question in GET query or in POST body
            string question = null;
            if (executionContext.BindingContext.BindingData.TryGetValue("question", out object value))
            {
                // Yes, save the string value
                question = value as string;
            }
            logger.LogInformation($"Question = '{question}'.");

            // Ask the Classic Magic 8 Ball service the provided question
            var magic8Ball = new Classic.ClassicMagic8Ball();
            try
            {
                await magic8Ball.AskAsync(question);
                logger.LogInformation($"Answer = '{magic8Ball.Answer}', Type = '{magic8Ball.Type}'.");
            }
            catch (Exception ex)
            {
                // Return error message
                string msg = ex.Message;
                if (null != ex.InnerException) msg += $"{Environment.NewLine}{ex.InnerException.Message}";
                var error = req.CreateResponse(HttpStatusCode.BadRequest);
                await error.WriteStringAsync(msg);
                return error;
            }

            // Create JSON serializer that handles enumerations
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
            };
            var serializer = new JsonObjectSerializer(options);
            
            // Return Magic8Ball object as JSON
            var response = req.CreateResponse(HttpStatusCode.OK);
            await response.WriteAsJsonAsync(magic8Ball, serializer);

            return response;
        }

        [Function("App")]
        public static HttpResponseData App([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("App");
            logger.LogInformation("C# HTTP trigger function processing an 'App' request...");

            // Redirect to Magic 8 Ball Azure Static Web App
            string Url = Environment.GetEnvironmentVariable("Magic8Ball_WebApp_URL");
            var response = req.CreateResponse(HttpStatusCode.Moved);
            response.Headers.Add("Location", Url);

            return response;
        }
    }
}
