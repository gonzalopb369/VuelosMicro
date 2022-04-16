using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves;

namespace Vuelos.Domain.Model.Vuelos
{
    public class Vuelos : AggregateRoot<Guid>
    {
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaFinal { get; private set; }

        private readonly ICollection<AsientosAeronave> _listaAsientos;


        public IReadOnlyCollection<AsientosAeronave> ListaAsientos
        {
            get
            {
                return new ReadOnlyCollection<AsientosAeronave>(_listaAsientos.ToList());
            }
        }        

    }
}
