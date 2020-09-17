using CoffeeMaker.DataAccess.Models;

namespace CoffeeMaker.DataAccess.Repositories
{
    class ServiceDetailsRepository : BaseRepository<ServiceDetails, CoffeeMakerContext>
    {
        public ServiceDetailsRepository(CoffeeMakerContext context) : base(context)
        {
        }
    }
}
