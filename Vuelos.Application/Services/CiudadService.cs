using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    public class CiudadService : ICiudadService
    {
        public Task<string> GenerarNroCiudadAsync() => Task.FromResult("ABC");
    }
}
