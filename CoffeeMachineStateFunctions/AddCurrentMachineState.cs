using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using MongoDB.Driver;
using CoffeeMachineStateFunctions.Models;

namespace CoffeeMachineStateFunctions
{
    public class AddCurrentMachineStatex 
    {
        private readonly MongoClient _mongoClient;
        private readonly IMongoCollection<MachineState> _machineStates;
        
        public AddCurrentMachineStatex(MongoClient mongoClient)
        {
            _mongoClient = mongoClient;
            var database = _mongoClient.GetDatabase("CoffeeMaker");
            _machineStates = database.GetCollection<MachineState>("CoffeeMakerStatuses");
        }
        [FunctionName("AddCurrentMachineState")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "AddState")] HttpRequest req,
            ILogger log)
        {
            IActionResult returnValue = null;

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

            var input = JsonConvert.DeserializeObject<MachineState>(requestBody);

            var coffeeMachineState = new MachineState
            {
                CoffeeMachineId = input.CoffeeMachineId,
                Date = input.Date,
                ErrorStatus = input.ErrorStatus,
                Status = input.Status
            };

            try
            {
                _machineStates.InsertOne(coffeeMachineState);
                returnValue = new OkObjectResult(coffeeMachineState);
            }
            catch (Exception ex)
            {
                returnValue = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }


            return returnValue;
        }
    }
}
