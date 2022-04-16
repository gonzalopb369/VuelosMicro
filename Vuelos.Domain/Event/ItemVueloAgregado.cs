using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.ValueObjects;


namespace Vuelos.Domain.Event
{
    public record ItemVueloAgregado : DomainEvent
    {
        //public Guid ProductoId { get; }
        public NroVueloValue NroVuelo { get; }
        public bool Lunes { get; }
        public bool Martes { get; }
        public bool Miercoles { get; }
        public bool Jueves { get; }
        public bool Viernes { get; }
        public bool Sabado { get; }
        public bool Domingo { get;  }
        public DateTime HoraSalida { get; }    // !!! SOLO DEBE SER HORA
        public DateTime HoraLlegada { get; }   // !!! ver. si sera string 
        public CodigoCiudadValue CiudadOrigen { get; }   // !!! relacionar x idciudad o por codigociudad
        public CodigoCiudadValue CiudadDestino { get; }    // !!! relacionar x idciudad o por codigociudad
        public PrecioValue PrecioVuelo { get; }
        public CantidadMillasValue CantidadMillas { get; }


        //public Guid ProductoId 
        public ItemVueloAgregado(NroVueloValue nroVuelo, bool lunes, bool martes, bool miercoles, bool jueves, bool viernes,
                                bool sabado, bool domingo, DateTime horaSalida, DateTime horaLlegada, CodigoCiudadValue ciudadOrigen,
                                CodigoCiudadValue ciudadDestino, PrecioValue precioVuelo, CantidadMillasValue cantidadMillas) 
                        : base(DateTime.Now)
        {
            //Guid ProductoId
            NroVuelo = nroVuelo;
            Lunes = lunes;
            Martes = martes;
            Miercoles = miercoles;
            Jueves = jueves;
            Viernes = viernes;
            Sabado = sabado;
            Domingo = domingo;
            HoraSalida = horaSalida;
            HoraLlegada = horaLlegada;
            CiudadOrigen = ciudadOrigen;
            CiudadDestino = ciudadDestino;
            PrecioVuelo = precioVuelo;
            CantidadMillas = cantidadMillas;
        }
        
    }
}
