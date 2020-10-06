using CoffeeMaker.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.BusinessLogic.Interfaces
{
    public interface IServiceDetailsService
    {
        Task<List<ServiceDetailsDTO>> GetMachineServiceDetails(int id);
    }
}
