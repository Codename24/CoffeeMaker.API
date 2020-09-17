using CoffeeMaker.DataAccess.Interfaces;
using CoffeeMaker.DataAccess.Models;

namespace CoffeeMaker.DataAccess.Repositories
{
    public class CoffeeMachineRepository : BaseRepository<CoffeeMachine,CoffeeMakerContext>, ICoffeeMachineRepository
    {
        public CoffeeMachineRepository(CoffeeMakerContext context) : base(context)
        {
        }
    }
}
