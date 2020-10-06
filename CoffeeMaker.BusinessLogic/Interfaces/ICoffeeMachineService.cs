using CoffeeMaker.BusinessLogic.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeMaker.BusinessLogic.Interfaces
{
    public interface ICoffeeMachineService
    {
        Task<CoffeeMachineDTO> Get(int id);
        Task<CoffeeMachineDTO> Add(CoffeeMachineDTO coffeeMachine);
        Task<List<CoffeeMachineDTO>> GetAllAsync();
    }
}
