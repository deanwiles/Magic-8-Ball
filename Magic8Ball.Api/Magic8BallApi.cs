using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
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
            logger.LogInformation("C# HTTP trigger function processed an 'Ask' request.");

            string question = null;
            if (executionContext.BindingContext.BindingData.TryGetValue("question", out object value))
                question = value as string;
            // TODO: else check for POST body as json
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
