using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Ciudades;

namespace Vuelos.Domain.Factories
{
    public class CiudadFactory : ICiudadFactory
    {
        public Ciudad CrearCiudad(string codigoCiudad, string nombreCiudad, string nombreAeropuerto,   // Añadido
                    bool estadoAeropuerto)
        {
            return new Ciudad(codigoCiudad, nombreCiudad, nombreAeropuerto, estadoAeropuerto);
        }


        public Ciudad Create(string codigoCiudad)  //!!!, string matricula)
        {
            return new Ciudad(codigoCiudad);    //!!! ver. si esta bien el codigoCiudad
        }
    }
}
