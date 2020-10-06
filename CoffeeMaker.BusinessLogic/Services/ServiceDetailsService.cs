using CoffeeMaker.BusinessLogic.Interfaces;
using CoffeeMaker.BusinessLogic.Models;
using CoffeeMaker.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.BusinessLogic.Services
{
    public class ServiceDetailsService : IServiceDetailsService
    {
        private IServiceDetailsRepository _serviceDetailsRepository;
        public ServiceDetailsService(IServiceDetailsRepository serviceDetailsRepository)
        {
            _serviceDetailsRepository = serviceDetailsRepository;
        }

        public async Task<List<ServiceDetailsDTO>> GetMachineServiceDetails(int id)
        {
            var serviceDetail = await _serviceDetailsRepository.GetServiceDetailsByMachineId(id);
            return serviceDetail.Select(c => new ServiceDetailsDTO()
            {
                CoffeeMachineId = c.CoffeeMachineId,
                CoffeeMachineName = c.CoffeeMachine.Name,
                ServiceDate = c.ServiceDate,
                ServiceEmployeeId = c.ServiceEmployeeId
            }).ToList();
        }
    }
}
