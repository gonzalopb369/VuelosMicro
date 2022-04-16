using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Application.Services
{
    public class AeronaveService : IAeronaveService
    {
        public Task<string> GenerarNroAeronaveAsync() => Task.FromResult("ABC");
    }
}
