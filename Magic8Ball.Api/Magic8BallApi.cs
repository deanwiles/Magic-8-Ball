using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Magic8Ball.Api
{
    public class MagicQuestion
    {
        public string Question { get; set; }
    }

    public static class Magic8BallApi
    {
        [Function("Ask")]
        public static async Task<HttpResponseData> Ask([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("Ask");
            logger.LogInformation("C# HTTP trigger function processed an 'Ask' request.");

            // Check for Question in GET query
            string question;
            if (executionContext.BindingContext.BindingData.TryGetValue("question", out object value))
            {
                // Yes, save the string value
                question = value as string;
            }
            else
            {
                // No, check for Question in POST body
                try
                {
                    question = (await req.ReadFromJsonAsync<MagicQuestion>()).Question;
                    //var body = await new StreamReader(req.Body).ReadToEndAsync();
                    //question = JsonSerializer.Deserialize<MagicQuestion>(body)?.Question;
                }
                catch (Exception ex)
                {
                    // Return error back to caller with some context
                    var error = req.CreateResponse(HttpStatusCode.BadRequest);
                    await error.WriteStringAsync("Need Question as JSON");
                    return error;
                }
            }
            logger.LogInformation($"Question = '{question}'.");

            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //question = question ?? data?.question;

            // TODO: call ClassicMagic8Ball to get answer and return object
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString($"Question = '{question}'{Environment.NewLine}Answer is soon to come...");

            return response;
        }
    }
}
