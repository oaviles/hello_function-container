using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace oafuntion_container
{
    public static class getGuid
    {
        [FunctionName("getGuid")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string value = req.Query["event"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            value = value ?? data?.value;

            Guid guid = Guid.NewGuid();

            string responseMessage = string.IsNullOrEmpty(value)
                ? "This HTTP triggered function executed successfully. Pass a event in the query string or in the request body for a personalized response."
                : $"Your event value is {guid.ToString()}.";

            return new OkObjectResult(responseMessage);
        }
    }
}
