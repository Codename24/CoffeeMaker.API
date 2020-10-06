using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeMaker.BusinessLogic.Interfaces;
using CoffeeMaker.BusinessLogic.Models;
using Microsoft.AspNetCore.Http;
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
        public async Task<List<CoffeeMachineDTO>> GetCoffeeMachineDTOs()
            => await _coffeeMachineService.GetAllAsync();
    }
}
