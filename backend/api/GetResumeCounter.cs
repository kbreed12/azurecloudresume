using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Company.Function
{
    public static class GetResumeCounter
    {
        [FunctionName("GetResumeCounter")]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [CosmosDB(
                databaseName: "AzureCloudResume",
                containerName: "Counter",
                Connection = "AzureCloudResumeConnectionString", // Corrected
                Id = "1",
                PartitionKey = "1")] Counter counter,
            [CosmosDB(
                databaseName: "AzureCloudResume",
                containerName: "Counter",
                Connection = "AzureCloudResumeConnectionString", // Corrected
                Id = "1",
                PartitionKey = "1")] out Counter updatedCounter,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            // Increment the counter
            updatedCounter = counter;
            updatedCounter.Count += 1;

            // Serialize the updated counter to JSON
            var jsonToReturn = JsonConvert.SerializeObject(updatedCounter);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent(jsonToReturn, System.Text.Encoding.UTF8, "application/json")
            };
        }
    }
}
