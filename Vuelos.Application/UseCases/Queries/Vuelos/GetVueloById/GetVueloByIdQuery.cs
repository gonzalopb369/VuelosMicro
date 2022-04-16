using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelos;


namespace Vuelos.Application.UseCases.Queries.Vuelos.GetVueloById
{
    public class GetVueloByIdQuery : IRequest<VueloDto>
    {
        public Guid Id { get; set; }

        public GetVueloByIdQuery(Guid id)
        {
            Id = id;
        }


        public GetVueloByIdQuery() 
        {
        }
    }
}
