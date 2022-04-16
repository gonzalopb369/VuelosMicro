using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vuelos.Domain.Event
{
    public record CiudadCreada : DomainEvent
    {
        public Guid IdCiudad { get; } // Como es inmutable no va tener "set"
        public CodigoCiudadValue CodigoCiudad { get; }    

        public CiudadCreada(Guid idCiudad, CodigoCiudadValue codigoCiudad) : base(DateTime.Now)
        {
            IdCiudad = idCiudad;
            CodigoCiudad = codigoCiudad;
        }
    }
}
