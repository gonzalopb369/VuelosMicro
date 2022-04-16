using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Aeronave;


namespace Vuelos.Application.UseCases.Queries.Aeronaves.GetAeronaveById
{
    public class GetAeronaveByIdQuery : IRequest<AeronaveDto>
    {
        public Guid Id { get; set; }

        public GetAeronaveByIdQuery(Guid id)
        {
            Id = id;
        }

        public GetAeronaveByIdQuery() { }
    }
}
