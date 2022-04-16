using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.ValueObjects;

namespace Vuelos.Domain.Event
{
    public record AsientoAeronaveAgregada : DomainEvent
    {
        public Guid IdAsiento { get; }
        public NroAsientoValue NroAsiento { get; }
        public EstadoAsientoValue EstadoAsiento { get; }


        public AsientoAeronaveAgregada(Guid idAsiento, NroAsientoValue nroAsiento, EstadoAsientoValue estadoAsiento) : base(DateTime.Now)
        {
            IdAsiento = idAsiento;
            NroAsiento = nroAsiento;
            EstadoAsiento = estadoAsiento;            
        }
    }
}
