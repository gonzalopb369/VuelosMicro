using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Event;
using Vuelos.Domain.ValueObjects;

namespace Vuelos.Domain.Model.Vuelos
{
    public class VueloOLD : AggregateRoot<Guid>
    {
        //public Guid idVuelo { get; private set; }
        public NroVueloValue NroVuelo { get; private set; }
        public bool Lunes { get; private set; }
        public bool Martes { get; private set; }
        public bool Miercoles { get; private set; }
        public bool Jueves { get; private set; }
        public bool Viernes { get; private set; }
        public bool Sabado { get; private set; }
        public bool Domingo { get; private set; }
        public DateTime HoraSalida { get; private set; }
        public DateTime HoraLlegada { get; private set; }
        public CodigoCiudadValue CiudadOrigen { get; private set; }
        public CodigoCiudadValue CiudadDestino { get; private set; }
        public PrecioValue PrecioVuelo { get; private set; }


        public VueloOLD(NroVueloValue nroVuelo, bool lunes, bool martes, bool miercoles, bool jueves, bool viernes,
                        bool sabado, bool domingo, DateTime horaSalida, DateTime horaLlegada, CodigoCiudadValue ciudadOrigen,
                        CodigoCiudadValue ciudadDestino, PrecioValue precioVuelo)
        {
            Id = Guid.NewGuid();
            NroVuelo = nroVuelo;
            PrecioVuelo = new PrecioValue(0m);
            //Detalle = new List<DetallePedido>();
        }


        //public void AgregarItem(Guid productoId, int cantidad, decimal precio, string instrucciones)
        //{
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


        public void ConsolidarPedido()
        {
            var evento = new VueloCreado(Id, NroVuelo);
            AddDomainEvent(evento);
        }
    }
}
