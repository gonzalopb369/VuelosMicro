using MediatR;
using System;
using System.Collections.Generic;
using Vuelos.Application.Dto.Vuelos;


namespace Vuelos.Application.UseCases.Command.Vuelos
{
    public class CrearVueloCommand : IRequest<Guid>
    {
        public string NroItinerario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }


        public List<VueloProgramadoDto> VueloProgramado { get; set; }


        private CrearVueloCommand() 
        { 
        }


        public CrearVueloCommand(List<VueloProgramadoDto> vueloProgramado)
        {
            VueloProgramado = vueloProgramado;
        }
        
    }
}
