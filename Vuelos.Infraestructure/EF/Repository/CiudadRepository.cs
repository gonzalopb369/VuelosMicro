using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Ciudades;
using Vuelos.Domain.Repositories;
using Vuelos.Infraestructure.EF.Contexts;

namespace Vuelos.Infraestructure.EF.Repository
{
    public class CiudadRepository : ICiudadRepository
    {
        public readonly DbSet<Ciudad> _ciudades;


        public CiudadRepository(WriteDbContext context)
        {
            _ciudades = context.Ciudad;
        }


        public async Task CreateAsync(Ciudad obj)
        {
            await _ciudades.AddAsync(obj);
        }


        public async Task<Ciudad> FindByIdAsync(Guid id)
        {
            return await _ciudades.SingleOrDefaultAsync(x => x.Id == id);
        }


        public Task RemoveAsync(Ciudad obj)
        {
            _ciudades.Remove(obj);
            return Task.CompletedTask;
        }


        public Task UpdateAsync(Ciudad obj)
        {
            _ciudades.Update(obj);
            return Task.CompletedTask;
        }
    }
}
