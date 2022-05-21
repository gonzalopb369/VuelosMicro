using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vuelos.Application.Services
{
    public class AeronaveService : IAeronaveService
    {
        //public Task<string> GenerarNroAeronaveAsync() => Task.FromResult("ABC");

        public Task<string> GenerarNroAeronaveAsync()
        {
            Random Aleatorio = new Random();
            int NumAleatorio = Aleatorio.Next(10, 100);
            string nroAeronave = Convert.ToString(NumAleatorio);
            return Task.FromResult(nroAeronave);
        }
        
    }
}
