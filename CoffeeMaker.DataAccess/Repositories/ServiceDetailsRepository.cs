using CoffeeMaker.DataAccess.Interfaces;
using CoffeeMaker.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMaker.DataAccess.Repositories
{
    public class ServiceDetailsRepository : BaseRepository<ServiceDetails, CoffeeMakerContext>, IServiceDetailsRepository
    {
        private readonly CoffeeMakerContext _context;
        public ServiceDetailsRepository(CoffeeMakerContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<ServiceDetails>> GetServiceDetailsByMachineId(int coffeeMachineId) =>
          await _context
            .ServiceDetails
            .Where(c => c.CoffeeMachineId == coffeeMachineId)
            .ToListAsync();

    }
}
