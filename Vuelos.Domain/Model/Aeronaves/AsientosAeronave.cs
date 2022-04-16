using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves.ValueObjects;
using Vuelos.Domain.ValueObjects;

namespace Vuelos.Domain.Model.Aeronaves
{
    public class AsientosAeronave : Entity<Guid>
    {
        public NroAsientoValue NroAsiento { get; private set; }
        public FilaAsientoValue Fila { get; private set; }
        public ColumnaAsientoValue Columna { get; private set; }
        public EstadoAsientoValue EstadoAsiento { get; private set; }   // Libre, ocupado, restringido


        internal AsientosAeronave(NroAsientoValue nroAsiento, FilaAsientoValue fila, ColumnaAsientoValue columna, 
                            EstadoAsientoValue estadoAsiento)
        {
            Id = Guid.NewGuid();    //!!! Verificar si va esto
            NroAsiento = nroAsiento;
            Fila = fila;
            Columna = columna;
            EstadoAsiento = estadoAsiento;
        }

        
        internal void ModificarAsiento(FilaAsientoValue fila, ColumnaAsientoValue columna, // NO se puede modificar el NroAsiento
                            EstadoAsientoValue estadoAsiento)
        {            
            Fila = fila;
            Columna = columna;
            EstadoAsiento = estadoAsiento;
        }

    }
}
