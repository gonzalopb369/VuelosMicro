using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vuelos.Domain.Event
{
    public record VueloCreado : DomainEvent
    {
        public Guid VueloId { get; } // Como es inmutable no va tener "set" !!! ver. si se utilizara ese
        public string NroItinerario { get; }


        public VueloCreado(Guid vueloId, string nroItinerario) : base(DateTime.Now)
        {
            VueloId = vueloId;
            NroItinerario = nroItinerario;
        }
    }
}
