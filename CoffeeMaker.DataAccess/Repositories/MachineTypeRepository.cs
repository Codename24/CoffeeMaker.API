using CoffeeMaker.DataAccess.Models;

namespace CoffeeMaker.DataAccess.Repositories
{
    class MachineTypeRepository : BaseRepository<MachineType, CoffeeMakerContext>
    {
        public MachineTypeRepository(CoffeeMakerContext context) : base(context)
        {
        }
    }
}
