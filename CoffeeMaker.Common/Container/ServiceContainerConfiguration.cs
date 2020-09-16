using CoffeeMaker.Common.Connections;
using CoffeeMaker.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMaker.Common.Container
{
    public static class ServiceContainerConfiguration
    {
        public static void AddDbContext(this IServiceCollection serviceCollection,
             IConfiguration configuration, IConfigurationRoot configRoot)
        {
            serviceCollection
                .AddDbContext<CoffeeMakerContext>(options =>
                   options
                   .UseSqlServer(ConnectionStringManager.ConnectionStringFromConfig(configuration, configRoot))
                );
        }
    }
}
