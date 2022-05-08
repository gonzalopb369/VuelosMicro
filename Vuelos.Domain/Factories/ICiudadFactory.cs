using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Ciudades;


namespace Vuelos.Domain.Factories
{
    public interface ICiudadFactory
    {
        Ciudad Create(string codigoCiudad);  //!!! verificar si esta bien);

        Ciudad CrearCiudad(string codigoCiudad, string nombreCiudad, string nombreAeropuerto,   // Añadido
                    bool estadoAeropuerto);
                    
    }
}
