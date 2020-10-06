using AutoMapper;
using CoffeeMaker.BusinessLogic.Models;
using CoffeeMaker.DataAccess.Models;

namespace CoffeeMaker.API.Mappings
{
    public class CoffeeMachineMappingProfile : Profile
    {
        public CoffeeMachineMappingProfile()
        {
            CreateMap<CoffeeMachineDTO, CoffeeMachine>();
            CreateMap<CoffeeMachine, CoffeeMachineDTO>();
        }
    }
}
