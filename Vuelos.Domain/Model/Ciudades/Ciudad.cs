using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Ciudades
{
    public class Ciudad : AggregateRoot<Guid>
    {        
        public CodigoCiudadValue CodigoCiudad { get; private set; }
        public NombreCiudadValue NombreCiudad { get; private set; }
        public NombreAeropuertoValue NombreAeropuerto { get; private set; }
        public bool EstadoAeropuerto { get; set; }      // true=habilitado      false=cerrado


        public Ciudad(CodigoCiudadValue codigoCiudad, NombreCiudadValue nombreCiudad, 
                    NombreAeropuertoValue nombreAeropuerto, bool estadoAeropuerto)
        {
            Id = Guid.NewGuid();            
            CodigoCiudad = codigoCiudad;
            NombreCiudad = nombreCiudad;
            NombreAeropuerto = nombreAeropuerto;
            EstadoAeropuerto = estadoAeropuerto;
        }
    }
}
