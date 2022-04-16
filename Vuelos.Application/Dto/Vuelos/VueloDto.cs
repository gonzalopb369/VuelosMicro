using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Dto.Vuelos
{
    public class VueloDto
    {
        public Guid Id { get; set; }
        public string NroItinerario { get;  set; }
        public DateTime FechaInicio { get;  set; }
        public DateTime FechaFinal { get;  set; }        
        public ICollection<VueloProgramadoDto> VueloProgramado { get; set; }


        public VueloDto()
        {
            VueloProgramado = new List<VueloProgramadoDto>();
        }
    }
}
