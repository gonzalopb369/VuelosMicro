using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Vuelos.Application.Services;
using Vuelos.Domain.Factories;
using MediatR;



namespace Vuelos.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly()); // Mapea los comandos con sus respectivos handlers
            services.AddTransient<IAeronaveService, AeronaveService>(); // crea instancia de AeronaveService
            services.AddTransient<IAeronaveFactory, AeronaveFactory>();
            services.AddTransient<IVueloService, VueloService>(); // crea instancia de AeronaveService
            services.AddTransient<IVueloFactory, VueloFactory>();   
            services.AddTransient<ICiudadService, CiudadService>(); // crea instancia de ciudadservice
            services.AddTransient<ICiudadFactory, CiudadFactory>();
            return services;
        }
    }
}
