using MediatR;
using Vuelos.Application.Dto.Aeronave;
using System;
using System.Collections.Generic;


namespace Vuelos.Application.UseCases.Command.Aeronaves
{
    public class CrearAeronaveCommand : IRequest<Guid>  // !!! cambiar el Guid x el que corresponda
    {
        //public Guid Id { get; set; }
        public string NroAeronave { get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int CapacidadAsientos { get; set; }
        public int CapacidadCombustible { get; set; }
        public bool EsActivo { get; set; }

        public List<AsientosAeronaveDto> DetalleAsientos { get;  set; }

        private CrearAeronaveCommand() { }


        public CrearAeronaveCommand(List<AsientosAeronaveDto> detalleAsientos)
        {
            DetalleAsientos = detalleAsientos;
        }

    }
}
