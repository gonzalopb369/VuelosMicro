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
        public Guid IdVuelo { get; } // Como es inmutable no va tener "set"
        public string NroVuelo { get; }


        public VueloCreado(Guid idVuelo, string nroVuelo) : base(DateTime.Now)
        {
            IdVuelo = idVuelo;
            NroVuelo = nroVuelo;
        }
    }
}
