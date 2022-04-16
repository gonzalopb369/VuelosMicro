using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves;
using Vuelos.Domain.Repositories;


namespace Vuelos.Infraestructure.EF.Repository
{
    public class AeronaveRepository : IAeronaveRepository
    {
        public Task CreateAsync(Aeronave obj)
        {
            Console.WriteLine($"Insertando la Aeronave: {obj.NroAeronave}");
            return Task.CompletedTask;
        }


        public Task<Aeronave> FindByIdAsync(Guid id)
        {
            Console.WriteLine($"Retornando la Aeronave: {id}");
            return null;
        }


        public Task UpdateAsync(Aeronave obj)
        {
            Console.WriteLine($"Actualizando la Aeronave: {obj.NroAeronave}");
            return Task.CompletedTask;
        }
    }
}
