using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vuelos.Application.Dto.Vuelos
{
    public class VueloProgramadoDto
    {
        //public Guid ProductoId { get; set; }
        public string NroVuelo { get;  set; }
        public bool Lunes { get;  set; }
        public bool Martes { get;  set; }
        public bool Miercoles { get;  set; }
        public bool Jueves { get;  set; }
        public bool Viernes { get;  set; }
        public bool Sabado { get;  set; }
        public bool Domingo { get;  set; }
        public string HoraSalida { get;  set; }   
        public string HoraLlegada { get;  set; }   
        public string CiudadOrigen { get;  set; }   // !!! relacionar x idciudad o por codigociudad
        public string CiudadDestino { get;  set; }    // !!! relacionar x idciudad o por codigociudad
        public decimal PrecioVuelo { get;  set; }
        public decimal CantidadMillas { get;  set; }
    }
}
