using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Dto.Ciudad
{
    public class CiudadDto
    {
        public Guid Id { get; set; }
        public string CodigoCiudad { get; set; }
        public string NombreCiudad { get; set; }
        public string NombreAeropuerto { get; set; }
        public bool EstadoAeropuerto { get; set; }

        public CiudadDto()
        {
        }
    }
}
