using AutoMapper;
using CoffeeMaker.BusinessLogic.Interfaces;
using CoffeeMaker.BusinessLogic.Models;
using CoffeeMaker.DataAccess.Interfaces;
using CoffeeMaker.DataAccess.Models;
using CoffeeMaker.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.BusinessLogic.Repositories
{
    public class CoffeeMachchineService: ICoffeeMachineService
    {
        private ICoffeeMachineRepository _coffeeMachineRepository;
        private readonly IMapper _mapper;
        public CoffeeMachchineService(ICoffeeMachineRepository coffeeMachineRepository, IMapper mapper)
        {
            _coffeeMachineRepository = coffeeMachineRepository;
            _mapper = mapper;
        }

        public async Task<CoffeeMachineDTO> Get(int id)
            => _mapper.Map<CoffeeMachineDTO>(await _coffeeMachineRepository.Get(id));

        public async Task<CoffeeMachineDTO> Add(CoffeeMachineDTO coffeeMachine)
        {
            var result = await _coffeeMachineRepository.Add(_mapper.Map<CoffeeMachine>(coffeeMachine));
            return _mapper.Map<CoffeeMachineDTO>(result);
        }

        public async Task<CoffeeMachineDTO> Update(CoffeeMachineDTO coffeeMachine)
        {
            var result = await _coffeeMachineRepository.Update(_mapper.Map<CoffeeMachine>(coffeeMachine));
            return _mapper.Map<CoffeeMachineDTO>(result);
        }

        public async Task<CoffeeMachineDTO> Delete(int id)
        {
            var result = await _coffeeMachineRepository.Delete(id);
            return _mapper.Map<CoffeeMachineDTO>(result);
        }

        public async Task<List<CoffeeMachineDTO>> GetAllAsync()
            => _mapper.Map<List<CoffeeMachineDTO>>(await _coffeeMachineRepository.GetAll());

    }
}
