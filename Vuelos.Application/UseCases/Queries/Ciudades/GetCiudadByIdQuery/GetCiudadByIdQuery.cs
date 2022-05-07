using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Ciudad;

namespace Vuelos.Application.UseCases.Queries.Ciudades.GetCiudadByIdQuery
{
    public class GetCiudadByIdQuery : IRequest<CiudadDto>
    {
        public Guid Id { get; set; }

        public GetCiudadByIdQuery(Guid id)
        {
            Id = id;
        }


        public GetCiudadByIdQuery() { }
    }
}
