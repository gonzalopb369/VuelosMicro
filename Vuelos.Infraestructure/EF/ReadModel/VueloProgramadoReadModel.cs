using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Infraestructure.EF.ReadModel
{
    public class VueloProgramadoReadModel
    {
        public Guid Id { get; set; }
        public string NroVuelo { get; set; }
        public bool Lunes { get; set; }
        public bool Martes { get; set; }
        public bool Miercoles { get; set; }
        public bool Jueves { get; set; }
        public bool Viernes { get; set; }
        public bool Sabado { get; set; }
        public bool Domingo { get; set; }
        public DateTime HoraSalida { get; set; }    // !!! SOLO DEBE SER HORA
        public DateTime HoraLlegada { get; set; }   // !!! ver. si sera string 
        public string CiudadOrigen { get; set; }   // !!! relacionar x idciudad o por codigociudad
        public string CiudadDestino { get; set; }    // !!! relacionar x idciudad o por codigociudad
        public decimal PrecioVuelo { get; set; }
        public decimal CantidadMillas { get; set; }

        public VueloReadModel Vuelo { get; set; }

        //public ProductoReadModel Producto { get; set; }
    }
}
