using CoffeeMachineStateFunctions.Helpers;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using System.Linq;

[assembly: WebJobsStartup(typeof(Startup))]
namespace CoffeeMachineStateFunctions.Helpers
{
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            var config = (IConfiguration)builder.Services.First(d => d.ServiceType == typeof(IConfiguration)).ImplementationInstance;

            builder.Services.AddSingleton((s) =>
            {
                MongoClient client = 
                new MongoClient("mongodb+srv://myuskiv:Y_Uskiv2401@cluster0.9fp2c.azure.mongodb.net/CoffeeMaker?retryWrites=true&w=majority");

                return client;
            });
        }
    }
}
