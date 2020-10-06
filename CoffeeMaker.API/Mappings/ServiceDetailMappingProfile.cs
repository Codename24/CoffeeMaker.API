using AutoMapper;
using CoffeeMaker.BusinessLogic.Models;
using CoffeeMaker.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMaker.API.Mappings
{
    public class ServiceDetailMappingProfile: Profile
    {
        public ServiceDetailMappingProfile()
        {
            CreateMap<ServiceDetailsDTO, ServiceDetails>()
                .ForMember(dest => dest.CoffeeMachineId, opt => opt.MapFrom(c => c.CoffeeMachineId))
                .ForMember(dest => dest.ServiceDate, opt => opt.MapFrom(c => c.ServiceDate))
                .ForMember(dest => dest.ServiceEmployeeId, opt => opt.MapFrom(c => c.ServiceEmployeeId));

            CreateMap<ServiceDetails, ServiceDetailsDTO>()
                .ForMember(dest => dest.CoffeeMachineId, opt => opt.MapFrom(c => c.CoffeeMachineId))
                .ForMember(dest => dest.ServiceDate, opt => opt.MapFrom(c => c.ServiceDate))
                .ForMember(dest => dest.ServiceEmployeeId, opt => opt.MapFrom(c => c.ServiceEmployeeId))
                .ForMember(dest=>dest.CoffeeMachineName, opt=>opt.MapFrom(c=>c.CoffeeMachine.Name));
        }
    }
}
