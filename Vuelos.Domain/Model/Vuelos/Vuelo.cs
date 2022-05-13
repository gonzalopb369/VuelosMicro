using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Event;
using Vuelos.Domain.Model.Aeronaves;
using Vuelos.Domain.ValueObjects;


namespace Vuelos.Domain.Model.Vuelos
{
    public class Vuelo : AggregateRoot<Guid>
    {
        public NroItinerarioValue NroItinerario { get; private set; }
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaFinal { get; private set; }

        private readonly ICollection<VueloProgramado> _vuelosProgramados;


        public IReadOnlyCollection<VueloProgramado> VuelosProgramados
        {
            get
            {
                return new ReadOnlyCollection<VueloProgramado>(_vuelosProgramados.ToList());
            }
        }


        private Vuelo() 
        { 
        }


        internal Vuelo(string nroItinerario)
        {
            Id = Guid.NewGuid();
            NroItinerario = nroItinerario;
            FechaInicio = DateTime.Now;
            FechaFinal = DateTime.Now.AddDays(30);
            _vuelosProgramados = new List<VueloProgramado>();
        }


        //Guid productoId,
        public void AgregarItem(NroVueloValue nroVuelo, bool lunes, bool martes, bool miercoles, bool jueves, bool viernes,
                               bool sabado, bool domingo, HoraVueloValue horaSalida, HoraVueloValue horaLlegada,
                               CodigoCiudadValue ciudadOrigen, CodigoCiudadValue ciudadDestino,
                               PrecioValue precioVuelo, CantidadMillasValue cantidadMillas)
        //public void AgregarItem(NroVueloValue nroVuelo, bool lunes, bool martes, bool miercoles, bool jueves, bool viernes,
        //                  bool sabado, bool domingo, string horaSalida, string horaLlegada,
        //                  string ciudadOrigen, string ciudadDestino,
        //                  PrecioValue precioVuelo, CantidadMillasValue cantidadMillas)
        {
            //var detallePedido = _detalle.FirstOrDefault(x => x.ProductoId == productoId);
            var detVueloProgramado = new VueloProgramado(nroVuelo, lunes, martes, miercoles, jueves, viernes,
                               sabado, domingo, horaSalida, horaLlegada, ciudadOrigen,
                               ciudadDestino, precioVuelo, cantidadMillas);
            _vuelosProgramados.Add(detVueloProgramado);
            //if (detallePedido is null)
            //{
            //    detallePedido = new DetallePedido(productoId, instrucciones, cantidad, precio);
            //    _detalle.Add(detallePedido);
            //}
            //else
            //{
            //    detallePedido.ModificarPedido(cantidad, precio);
            //}            
            AddDomainEvent(new ItemVueloAgregado(nroVuelo, lunes, martes, miercoles, jueves, viernes,
                               sabado, domingo, horaSalida, horaLlegada, ciudadOrigen,
                               ciudadDestino, precioVuelo, cantidadMillas));
        }


        public void ConsolidarVuelo()
        {
            var evento = new VueloCreado(Id, NroItinerario);
            AddDomainEvent(evento);
        }

    }
}
