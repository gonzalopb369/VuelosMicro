using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Ciudades;


namespace Vuelos.Domain.Repositories
{
    public interface ICiudadRepository : IRepository<Ciudad, Guid>
    {
        Task UpdateAsync(Ciudad obj);
        Task RemoveAsync(Ciudad obj);
    }
}
