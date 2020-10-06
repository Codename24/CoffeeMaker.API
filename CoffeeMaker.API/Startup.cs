using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoffeeMaker.BusinessLogic.Interfaces;
using CoffeeMaker.BusinessLogic.Models;
using CoffeeMaker.BusinessLogic.Repositories;
using CoffeeMaker.BusinessLogic.Services;
using CoffeeMaker.Common.Container;
using CoffeeMaker.DataAccess.Interfaces;
using CoffeeMaker.DataAccess.Models;
using CoffeeMaker.DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CoffeeMaker.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            configRoot = builder.Build();
        }

        public IConfiguration Configuration { get; }
        private readonly IConfigurationRoot configRoot;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext(Configuration, configRoot);
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<,>));
            services.AddTransient<ICoffeeMachineRepository, CoffeeMachineRepository>();
            services.AddTransient<IServiceDetailsRepository, ServiceDetailsRepository>();

            services.AddTransient<ICoffeeMachineService, CoffeeMachchineService>();
            services.AddTransient<IServiceDetailsService, ServiceDetailsService>();


            services.AddSwaggerOpenAPI();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CoffeeMakerAPI V1");
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
