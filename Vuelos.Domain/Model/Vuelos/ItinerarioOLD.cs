using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Event;

namespace Vuelos.Domain.Model.Vuelos
{
    public class ItinerarioOLD : Entity<Guid>
    {
        //public Guid IdItineario { get; private set; }
        public DateTime FechaInicio { get; set; }  // sin private el set
        public DateTime FechaFin { get; set; } // sin private el set
        public ICollection<VueloOLD> ListaVuelos { get; private set; }


        public ItinerarioOLD(DateTime fechaInicio, DateTime fechaFin)
        {
            Id = Guid.NewGuid();
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            ListaVuelos = new List<VueloOLD>();
        }


        //public void AgregarVuelo(NroVueloValue nroVuelo, bool lunes, bool martes, bool miercoles, bool jueves,
        //                bool viernes, bool sabado, bool domingo, DateTime horaSalida, DateTime horaLlegada,
        //                CodigoCiudadValue ciudadOrigen, CodigoCiudadValue ciudadDestino, PrecioValue precioVuelo)
        //{
        //    var nuevoVuelo = new Vuelo(nroVuelo, lunes, martes, miercoles, jueves, viernes, sabado, domingo, horaSalida, horaLlegada,
        //                    ciudadOrigen, ciudadDestino, precioVuelo);
        //    ListaVuelos.Add(nuevoVuelo);


        //    var detallePedido = Detalle.FirstOrDefault(x => x.ProductoId == productoId);
        //    if (detallePedido is null)
        //    {
        //        detallePedido = new DetallePedido(productoId, instrucciones, cantidad, precio);
        //        Detalle.Add(detallePedido);
        //    }
        //    else
        //    {
        //        detallePedido.ModificarPedido(cantidad, precio);
        //    }

        //    Total = Total + detallePedido.SubTotal;

        //    AddDomainEvent(new ItemPedidoAgregado(productoId, precio, cantidad));
        //}

        public void ConsolidarVuelo()
        {
            var evento = new ItinerarioCreadoXXX(Id, FechaInicio);
            AddDomainEvent(evento);
        }
    }
}

