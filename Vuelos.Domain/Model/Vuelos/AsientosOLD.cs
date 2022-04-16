using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.ValueObjects;


namespace Vuelos.Domain.Model.Vuelos
{
    public class Asientos : Entity<Guid>
    {
        public NroAsientoValue NroAsiento { get; private set; }
        public int Fila { get; private set; }
        public int Columna { get; private set; }
        public EstadoAsientoValue EstadoAsiento { get; private set; }
    }
}
