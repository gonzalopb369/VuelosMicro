using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Infraestructure.EF.ReadModel
{
    public class AsientosAeronaveReadModel
    {
        public Guid Id { get; set; }
        public string NroAsiento { get;  set; }
        public int Fila { get;  set; }
        public int Columna { get;  set; }
        public string EstadoAsiento { get;  set; }   // Libre, ocupado, restringido

        public AeronaveReadModel Aeronave { get; set; }

        //public CiudadReadModel Ciudad { get; set; } !!! No debe estar aqui
    }
}
