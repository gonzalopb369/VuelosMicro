using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Services
{
    public interface IAeronaveService
    {
        Task<string> GenerarNroAeronaveAsync(); // !!! ver como cambiar/corregir o aumentar nroaeronave
    }
}
