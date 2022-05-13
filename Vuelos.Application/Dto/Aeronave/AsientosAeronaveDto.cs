using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Dto.Aeronave
{
    public class AsientosAeronaveDto
    {     

        public string NroAsiento { get;  set; }
        public int Fila { get;  set; }
        public int Columna { get;  set; }
        public string EstadoAsiento { get;  set; }
    }
}
