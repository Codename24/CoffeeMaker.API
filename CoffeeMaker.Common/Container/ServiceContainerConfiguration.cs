using CoffeeMaker.Common.Connections;
using CoffeeMaker.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
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

        public static void AddSwaggerOpenAPI(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSwaggerGen(setupAction =>
            {
                setupAction.SwaggerDoc("v1", new OpenApiInfo { Title = "CoffeeMakerAPI", Version = "v1" });

                //var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);
                //setupAction.IncludeXmlComments(xmlCommentsFullPath);
            });
        }

        public static void AddController(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddControllers().AddNewtonsoftJson();
        }

        public static void AddVersion(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        }
    }
}
