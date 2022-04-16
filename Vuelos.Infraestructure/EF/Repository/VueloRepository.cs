using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Vuelos;
using Vuelos.Domain.Repositories;
using Vuelos.Infraestructure.EF.Contexts;

namespace Vuelos.Infraestructure.EF.Repository
{
    public class VueloRepository : IVueloRepository
    {
        public readonly DbSet<Vuelo> _vuelo;

        public VueloRepository(WriteDbContext context)
        {
            _vuelo = context.Vuelo;
        }


        public async Task CreateAsync(Vuelo obj)
        {
            await _vuelo.AddAsync(obj);
        }


        public async Task<Vuelo> FindByIdAsync(Guid id)
        {
            return await _vuelo.Include("_vuelosProgramados")
                    .SingleAsync(x => x.Id == id);
        }


        public Task UpdateAsync(Vuelo obj)
        {
            _vuelo.Update(obj);
            return Task.CompletedTask;
        }
    }
}
