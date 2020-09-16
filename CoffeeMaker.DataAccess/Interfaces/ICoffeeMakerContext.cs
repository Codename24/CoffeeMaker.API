using CoffeeMaker.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeMaker.DataAccess.Interfaces
{
    public interface ICoffeeMakerContext
    {
        DbSet<CoffeeMachine> CoffeeMachines { get; set; }
        DbSet<MachineType> MachineTypes { get; set; }
        DbSet<ServiceDetails> ServiceDetails { get; set; }
    }
}
