using MediatR;
using Pedidos.Application.Dto.Aeronave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pedidos.Application.UseCases.Command.Aeronave
{
    public class CrearAeronaveCommand : IRequest<Guid>  // !!! cambiar el Guid x el que corresponda
    {
        public List<AsientosAeronaveDto> DetalleAsientos { get; private set; }

        public CrearAeronaveCommand(List<AsientosAeronaveDto> detalleAsientos)
        {
            DetalleAsientos = detalleAsientos;
        }
    }
}
