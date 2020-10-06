using AutoMapper;
using CoffeeMaker.BusinessLogic.Interfaces;
using CoffeeMaker.BusinessLogic.Models;
using CoffeeMaker.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMaker.BusinessLogic.Services
{
    public class ServiceDetailsService : IServiceDetailsService
    {
        private IServiceDetailsRepository _serviceDetailsRepository;
        private readonly IMapper _mapper;
        public ServiceDetailsService(IServiceDetailsRepository serviceDetailsRepository, IMapper mapper)
        {
            _serviceDetailsRepository = serviceDetailsRepository;
            _mapper = mapper;
        }

        public async Task<List<ServiceDetailsDTO>> GetMachineServiceDetails(int id)
        {
            var serviceDetail = await _serviceDetailsRepository.GetServiceDetailsByMachineId(id);
            return _mapper.Map<List<ServiceDetailsDTO>>(serviceDetail);
        }
    }
}
