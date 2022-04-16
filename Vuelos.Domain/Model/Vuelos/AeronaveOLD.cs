using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Vuelos.ValueObjects;

namespace Vuelos.Domain.Model.Vuelos
{
    public class Aeronave : Entity<Guid>
    {
        public string marca { get; private set; }
        public string modelo { get; private set; }
        public MatriculaValue matricula { get; private set; }
        public int capacidadAsientos { get; private set; }
        public int capacidadCombustible { get; private set; }        
        public bool EstadoAeronave { get; set; }
        public ICollection<Asientos> ListaAsientos { get; private set; }
    }
}
