using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using CoffeeMachineStateFunctions.Models;

namespace CoffeeMachineStateFunctions
{
    public class GetMachineStatesLog
    {
        private readonly MongoClient _mongoClient;
        private readonly IMongoCollection<MachineState> _machineStates;

        public GetMachineStatesLog(MongoClient mongoClient)
        {
            _mongoClient = mongoClient;
            var database = _mongoClient.GetDatabase("CoffeeMaker");
            _machineStates = database.GetCollection<MachineState>("CoffeeMakerStatuses");
        }
        [FunctionName("GetMachineStatesLog")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "MachineStateLog/{id}")] HttpRequest req, int id,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            IActionResult returnValue = null;

            try
            {
                var result = _machineStates.Find(s => s.CoffeeMachineId == id).ToList();

                if (result == null)
                {
                    returnValue = new NotFoundResult();
                }
                else
                {
                    returnValue = new OkObjectResult(result);
                }
            }
            catch (Exception ex)
            {
               returnValue = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            return returnValue;
        }
    }
}
