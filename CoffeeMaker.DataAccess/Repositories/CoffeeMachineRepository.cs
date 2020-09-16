using CoffeeMaker.DataAccess.Models;

namespace CoffeeMaker.DataAccess.Repositories
{
    public class CoffeeMachineRepository : BaseRepository<CoffeeMachine,CoffeeMakerContext>
    {
        public CoffeeMachineRepository(CoffeeMakerContext context) : base(context)
        {
        }
    }
}
