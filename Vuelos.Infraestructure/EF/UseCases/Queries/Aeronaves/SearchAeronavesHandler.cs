using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Aeronave;
using Vuelos.Application.UseCases.Queries.Aeronaves.SearchAeronaves;
using Vuelos.Infraestructure.EF.Contexts;
using Vuelos.Infraestructure.EF.ReadModel;

namespace Vuelos.Infraestructure.EF.UseCases.Queries.Aeronaves
{
    public class SearchAeronavesHandler : IRequestHandler<SearchAeronavesQuery, ICollection<AeronaveDto>>
    {
        private readonly DbSet<AeronaveReadModel> _aeronaves;

        public SearchAeronavesHandler(ReadDbContext context)
        {
            _aeronaves = context.Aeronave;
        }


        public async Task<ICollection<AeronaveDto>> Handle(SearchAeronavesQuery request, CancellationToken cancellationToken)
        {
            var aeronaveList = await _aeronaves
                            .AsNoTracking()
                            .Include(x => x.DetalleAsientos)
                            //.ThenInclude(x => x.Producto)
                            .Where(x => x.NroAeronave.Contains(request.NroAeronave))
                            .ToListAsync();

            var result = new List<AeronaveDto>();

            foreach (var objAeronave in aeronaveList)
            {
                var aeronaveDto = new AeronaveDto()
                {
                    Id = objAeronave.Id,
                    NroAeronave = objAeronave.NroAeronave,
                    Matricula = objAeronave.Matricula,
                    Marca = objAeronave.Marca,
                    Modelo = objAeronave.Modelo,
                    CapacidadAsientos = objAeronave.CapacidadAsientos,
                    CapacidadCombustible = objAeronave.CapacidadCombustible,
                    EsActivo = objAeronave.EsActivo
                };
                foreach (var item in objAeronave.DetalleAsientos)
                {
                    aeronaveDto.DetalleAsientos.Add(new AsientosAeronaveDto()
                    {
                        NroAsiento = item.NroAsiento,
                        Fila = item.Fila,
                        Columna = item.Columna,
                        EstadoAsiento = item.EstadoAsiento
                    });
                }
                result.Add(aeronaveDto);
            }
            return result;
        }
    }
}
