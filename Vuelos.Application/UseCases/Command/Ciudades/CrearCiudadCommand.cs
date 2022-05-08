using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.UseCases.Command.Ciudades
{
    public class CrearCiudadCommand : IRequest<Guid>
    {
        public string CodigoCiudad { get;  set; }
        public string NombreCiudad { get;  set; }
        public string NombreAeropuerto { get;  set; }
        public bool EstadoAeropuerto { get;  set; }


        private CrearCiudadCommand() 
        {
        }


        public  CrearCiudadCommand(bool estadoAeropuerto) //!!! probando const no vacio
        {
            EstadoAeropuerto = estadoAeropuerto;
        }

    }
}
