using CoffeeMaker.BusinessLogic.Interfaces;
using CoffeeMaker.BusinessLogic.Repositories;
using CoffeeMaker.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.BusinessLogic
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly CoffeeMakerContext _coffeeMakerContext;
        private ICoffeeMachineService _coffeeMachineService;
        public UnitOfWork(CoffeeMakerContext coffeeMakerContext)
        {
            _coffeeMakerContext = coffeeMakerContext;
        }

        //public ICoffeeMachineService CoffeeMachineService
        //{
        //    get
        //    {
        //        return { _coffeeMachineService = _coffeeMachineService??new CoffeeMachchineService(_coffeeMakerContext.) }
        //    }
        //}
    }
}
