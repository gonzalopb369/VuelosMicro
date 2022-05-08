using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves;
using Vuelos.Domain.Repositories;


namespace Vuelos.Infraestructure.MemoryRepository
{
    public class MemoryAeronaveRepository : IAeronaveRepository
    {
        private readonly MemoryDatabase _database;

        public MemoryAeronaveRepository(MemoryDatabase database)
        {
            _database = database;
        }


        public Task CreateAsync(Aeronave obj)
        {
            _database.Aeronaves.Add(obj);
            return Task.CompletedTask;
        }


        public Task<Aeronave> FindByIdAsync(Guid id)
        {
            return Task.FromResult(_database.Aeronaves.FirstOrDefault(x => x.Id == id));
        }


        public Task UpdateAsync(Aeronave obj)
        {
            return Task.CompletedTask;
        }
    }
}
