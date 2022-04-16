using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Event
{
    public record ItinerarioCreadoXXX : DomainEvent
    {
        public Guid IdItinerario { get; } // Como es inmutable no va tener "set"
        public DateTime FechaInicio { get; }


        public ItinerarioCreadoXXX(Guid idItinerario, DateTime fechaInicio) : base(DateTime.Now)
        {
            IdItinerario = idItinerario;
            FechaInicio = fechaInicio;
        }
    }
}
