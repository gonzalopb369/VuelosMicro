using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelos;


namespace Vuelos.Application.UseCases.Queries.Vuelos.SearchVuelos
{
    public class SearchVuelosQuery : IRequest<ICollection<VueloDto>>
    {
        public string NroItinerario { get; set; }
    }
}
