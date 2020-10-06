using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeeMaker.BusinessLogic.Interfaces;
using CoffeeMaker.BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMaker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeMakerController : ControllerBase
    {
        ICoffeeMachineService _coffeeMachineService;
        IServiceDetailsService _serviceDetailsService;
        public CoffeeMakerController(ICoffeeMachineService coffeeMachineService, IServiceDetailsService serviceDetailsService)
        {
            _coffeeMachineService = coffeeMachineService;
            _serviceDetailsService = serviceDetailsService;
        }
        [HttpGet]
        public async Task<List<CoffeeMachineDTO>> GetAll()
            => await _coffeeMachineService.GetAllAsync();

        [HttpGet]
        [Route("{id}")]
        public async Task<CoffeeMachineDTO> GetById(int id)
            => await _coffeeMachineService.Get(id);

        [HttpGet]
        [Route("servicedetails/{id}")]
        public async Task<List<ServiceDetailsDTO>> GetCoffeeMachineServiceDetails(int id)
            => await _serviceDetailsService.GetMachineServiceDetails(id);

        [HttpPost]
        public async Task<CoffeeMachineDTO> Add(CoffeeMachineDTO coffeeMachine)
            => await _coffeeMachineService.Add(coffeeMachine);

        [HttpPut]
        public async Task<CoffeeMachineDTO> Update(CoffeeMachineDTO coffeeMachine)
            => await _coffeeMachineService.Update(coffeeMachine);

        [HttpDelete]
        public async Task<CoffeeMachineDTO> Delete(int id)
            => await _coffeeMachineService.Delete(id);
    }
}
