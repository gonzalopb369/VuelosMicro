using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using Vuelos.Domain.Event;
using Vuelos.Domain.ValueObjects;


namespace Vuelos.Domain.Model.Ciudades
{
    public class Ciudad : AggregateRoot<Guid>
    {        
        public CodigoCiudadValue CodigoCiudad { get; private set; }
        public NombreCiudadValue NombreCiudad { get; private set; }
        public NombreAeropuertoValue NombreAeropuerto { get; private set; }
        public bool EstadoAeropuerto { get; private set; }      // true=habilitado      false=cerrado


        private Ciudad()
        {
            EstadoAeropuerto = true;
        }


        internal Ciudad(string codigoCiudad)   // !!! ver. si añadir los demás campos
        {
            Id = Guid.NewGuid();
            CodigoCiudad = codigoCiudad;
            EstadoAeropuerto = true;
        }


        public Ciudad(CodigoCiudadValue codigoCiudad, NombreCiudadValue nombreCiudad, 
                    NombreAeropuertoValue nombreAeropuerto, bool estadoAeropuerto)
        {
            Id = Guid.NewGuid();            
            CodigoCiudad = codigoCiudad;
            NombreCiudad = nombreCiudad;
            NombreAeropuerto = nombreAeropuerto;
            EstadoAeropuerto = estadoAeropuerto;
        }


        public void ConsolidarCiudad()
        {
            var evento = new CiudadCreada(Id, CodigoCiudad);
            AddDomainEvent(evento);
        }

        //public void ReducirStock(CantidadValue cantidad)
        //{
        //    int stockResultante = StockActual - cantidad;
        //    if (stockResultante < 0)
        //    {
        //        throw new BusinessRuleValidationException("La cantidad de stock actual es insuficiente");
        //    }
        //    StockActual = stockResultante;
        //}
    }
}




