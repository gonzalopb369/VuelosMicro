using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    public class VueloService : IVueloService
    {   //!!! cambiar corregir

        //public Task<string> GenerarNroItinerarioAsync() => Task.FromResult("ABC");

        public Task<string> GenerarNroItinerarioAsync() 
        {
            Random Aleatorio = new Random();
            int NumAleatorio = Aleatorio.Next(100, 999);
            string NroItinerario = Convert.ToString(NumAleatorio);
            return Task.FromResult(NroItinerario);
        }
        
    }
}
