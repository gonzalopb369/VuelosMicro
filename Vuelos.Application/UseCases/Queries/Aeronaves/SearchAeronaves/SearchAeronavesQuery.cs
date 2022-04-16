using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Aeronave;


namespace Vuelos.Application.UseCases.Queries.Aeronaves.SearchAeronaves
{
    public class SearchAeronavesQuery : IRequest<ICollection<AeronaveDto>>
    {
        public string NroAeronave { get; set; }
    }
}
