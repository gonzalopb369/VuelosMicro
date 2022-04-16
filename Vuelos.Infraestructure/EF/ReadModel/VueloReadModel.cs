using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vuelos.Infraestructure.EF.ReadModel
{
    public class VueloReadModel
    {
        public Guid Id { get; set; }
        public string NroItinerario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }

        public ICollection<VueloProgramadoReadModel> DetVueloProgramado { get; set; }        
    }
}
