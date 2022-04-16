using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Repositories;
using Vuelos.Infraestructure.EF;
using Vuelos.Infraestructure.MemoryRepository;
using Vuelos.Infraestructure.EF.Repository;
using Microsoft.Extensions.Configuration;
using Vuelos.Application;
using MediatR;
using System.Reflection;
using Vuelos.Infraestructure.EF.Contexts;
using Microsoft.EntityFrameworkCore;


namespace Vuelos.Infraestructure
{
    public static class Extensions
    {      

        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddApplication();
            services.AddMediatR(Assembly.GetExecutingAssembly());

            var connectionString = configuration.GetConnectionString("VuelosDbConnectionString");

            services.AddDbContext<ReadDbContext>(context =>
                context.UseSqlServer(connectionString));
            services.AddDbContext<WriteDbContext>(context =>
                context.UseSqlServer(connectionString));

            services.AddScoped<IAeronaveRepository, AeronaveRepository>();
            services.AddScoped<IVueloRepository, VueloRepository>();
            //services.AddScoped<IProductoRepository, ProductoRepository>(); // COMPLETAR
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
