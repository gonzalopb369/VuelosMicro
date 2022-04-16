using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelos;
using Vuelos.Application.UseCases.Queries.Vuelos.SearchVuelos;
using Vuelos.Infraestructure.EF.Contexts;
using Vuelos.Infraestructure.EF.ReadModel;


namespace Vuelos.Infraestructure.EF.UseCases.Queries.Vuelos
{
    public class SearchVueloHandler :
        IRequestHandler<SearchVuelosQuery, ICollection<VueloDto>>
    {
        private readonly DbSet<VueloReadModel> _vuelo;

        public SearchVueloHandler(ReadDbContext context)
        {
            _vuelo = context.Vuelo;
        }

        public async Task<ICollection<VueloDto>> Handle(SearchVuelosQuery request, CancellationToken cancellationToken)
        {
            var vueloList = await _vuelo
                            .AsNoTracking()
                            .Include(x => x.DetVueloProgramado)
                            //.ThenInclude(x => x.Producto)
                            .Where(x => x.NroItinerario.Contains(request.NroItinerario))
                            .ToListAsync();

            var result = new List<VueloDto>();
            foreach (var objVuelo in vueloList)
            {
                var vueloDto = new VueloDto()
                {
                    Id = objVuelo.Id,
                    NroItinerario = objVuelo.NroItinerario,
                    FechaInicio = objVuelo.FechaInicio,
                    FechaFinal = objVuelo.FechaFinal
                };
                foreach (var item in objVuelo.DetVueloProgramado)
                {
                    vueloDto.VueloProgramado.Add(new VueloProgramadoDto()
                    {
                        NroVuelo = item.NroVuelo,
                        Lunes = item.Lunes,
                        Martes = item.Martes,
                        Miercoles = item.Miercoles,
                        Jueves = item.Jueves,
                        Viernes = item.Viernes,
                        Sabado = item.Sabado,
                        Domingo = item.Domingo,
                        HoraSalida = item.HoraSalida,
                        HoraLlegada = item.HoraLlegada,
                        CiudadOrigen = item.CiudadOrigen,
                        CiudadDestino = item.CiudadDestino,
                        PrecioVuelo = item.PrecioVuelo,
                        CantidadMillas = item.CantidadMillas
                    });
                }
                result.Add(vueloDto);
            }
            return result;
        }
    }
}
