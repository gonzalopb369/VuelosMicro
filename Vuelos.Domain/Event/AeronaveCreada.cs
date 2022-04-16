using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves.ValueObjects;

namespace Vuelos.Domain.Event
{
    public record AeronaveCreada : DomainEvent
    {
        public Guid IdAeronave { get; } // Como es inmutable no va tener "set"
        public MatriculaValue Matricula { get; }    


        public AeronaveCreada(Guid idAeronave, string matricula) : base(DateTime.Now)
        {
            IdAeronave = idAeronave;
            Matricula = matricula;
        }
    }
}
