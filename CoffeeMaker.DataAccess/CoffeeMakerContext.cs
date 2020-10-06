using CoffeeMaker.DataAccess.Interfaces;
using CoffeeMaker.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeMaker.DataAccess
{
    public class CoffeeMakerContext : DbContext, ICoffeeMakerContext
    {
        public CoffeeMakerContext() : base()
        {
        }

        public DbSet<CoffeeMachine> CoffeeMachines { get; set; }
        public DbSet<MachineType> MachineTypes { get; set; }
        public DbSet<ServiceDetails> ServiceDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CoffeeMaker.DB;Trusted_Connection=True;");
        }


    }
}
