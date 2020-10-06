using CoffeeMaker.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeMaker.DataAccess.Interfaces
{
    public interface IServiceDetailsRepository : IBaseRepository<ServiceDetails>
    {
        Task<List<ServiceDetails>> GetServiceDetailsByMachineId(int coffeeMachineId);
    }
}
