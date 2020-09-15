﻿using CoffeeMaker.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeMaker.DataAccess
{
    class CoffeeMakerContext : DbContext
    {
        public CoffeeMakerContext() : base()
        {
        }

        public DbSet<CoffeeMachine> CoffeeMachines { get; set; }
        public DbSet<MachineType> MachineTypes { get; set; }
        public DbSet<ServiceDetails> ServiceDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }


    }
}
