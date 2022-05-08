using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves;


namespace Vuelos.Infraestructure.MemoryRepository
{
    public class MemoryDatabase
    {
        private readonly List<Aeronave> _aeronaves;

        public List<Aeronave> Aeronaves
        {
            get { return _aeronaves; }
        }


        public MemoryDatabase()
        {
            _aeronaves = new List<Aeronave>();
        }
    }
}
