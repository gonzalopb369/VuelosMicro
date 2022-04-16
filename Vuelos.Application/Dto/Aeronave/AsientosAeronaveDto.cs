using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Dto.Aeronave
{
    public class AsientosAeronaveDto
    {
        //public NroAsientoValue NroAsiento { get; private set; }
        //public FilaAsientoValue Fila { get; private set; }
        //public ColumnaAsientoValue Columna { get; private set; }
        //public EstadoAsientoValue EstadoAsiento { get; private set; }

        public string NroAsiento { get;  set; }
        public int Fila { get;  set; }
        public int Columna { get;  set; }
        public string EstadoAsiento { get;  set; }
    }
}
