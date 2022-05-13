using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.ValueObjects;


namespace Vuelos.Domain.Model.Vuelos
{
    public class VueloProgramado : Entity<Guid>
    {
        public NroVueloValue NroVuelo { get; private set; }
        public bool Lunes { get; private set; }
        public bool Martes { get; private set; }
        public bool Miercoles { get; private set; }
        public bool Jueves { get; private set; }
        public bool Viernes { get; private set; }
        public bool Sabado { get; private set; }
        public bool Domingo { get; private set; }
        public HoraVueloValue HoraSalida { get; private set; }//     HoraVueloValue
        public HoraVueloValue HoraLlegada { get; private set; } //      HoraVueloValue
        public CodigoCiudadValue CiudadOrigen { get; private set; }   // !!! relacionar x idciudad o por codigociudad
        public CodigoCiudadValue CiudadDestino { get; private set; }    // !!! relacionar x idciudad o por codigociudad
        public PrecioValue PrecioVuelo { get; private set; }    
        public CantidadMillasValue CantidadMillas { get; private set; }


        public VueloProgramado()
        {
        }


        internal VueloProgramado(NroVueloValue nroVuelo, bool lunes, bool martes, bool miercoles,
                                bool jueves, bool viernes, bool sabado, bool domingo,
                                HoraVueloValue horaSalida, HoraVueloValue horaLlegada,
                                CodigoCiudadValue ciudadOrigen, CodigoCiudadValue ciudadDestino,
                                PrecioValue precioVuelo, CantidadMillasValue cantidadMillas)
        //internal VueloProgramado(NroVueloValue nroVuelo, bool lunes, bool martes, bool miercoles,
        //                   bool jueves, bool viernes, bool sabado, bool domingo,
        //                   string horaSalida, string horaLlegada,
        //                   string ciudadOrigen, string ciudadDestino,
        //                   PrecioValue precioVuelo, CantidadMillasValue cantidadMillas)
        {
            Id = Guid.NewGuid();
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
       

        internal void ModificarVueloProgramado(bool lunes, bool martes, bool miercoles, 
                                bool jueves, bool viernes, bool sabado, bool domingo, 
                                HoraVueloValue horaSalida, HoraVueloValue horaLlegada, 
                                CodigoCiudadValue ciudadOrigen, CodigoCiudadValue ciudadDestino, 
                                PrecioValue precioVuelo, CantidadMillasValue cantidadMillas)
        {
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
