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
    public static class HttpExample
    {
        [FunctionName("HttpExample")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            Random random = new Random();
            int value1 = random.Next(1, 100);
            int value2 = random.Next(1, 100);

            var result = new {
                Value1 = value1,
                Value2 = value2
            };

            return new JsonResult(result);
        }
    }
}
