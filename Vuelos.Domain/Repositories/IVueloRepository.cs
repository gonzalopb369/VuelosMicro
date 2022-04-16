using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Vuelos;


namespace Vuelos.Domain.Repositories
{
    public interface IVueloRepository : IRepository<VueloOLD, Guid>
    {
        Task UpdateAsync(VueloOLD obj);
        Task RemoveAsync(VueloOLD obj);
    }
}
