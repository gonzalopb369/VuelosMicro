using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelos;
using Vuelos.Domain.Model.Vuelos;
using Vuelos.Domain.Repositories;

namespace Vuelos.Application.UseCases.Queries.Vuelos.GetVueloById
{
    public class GetVueloByIdHandler : IRequestHandler<GetVueloByIdQuery, VueloDto>
    {
        private readonly IVueloRepository _vueloRepository;
        private readonly ILogger<GetVueloByIdQuery> _logger;


        public GetVueloByIdHandler(IVueloRepository vueloRepository, ILogger<GetVueloByIdQuery> logger)
        {
            _vueloRepository = vueloRepository;
            _logger = logger;
        }


        public async Task<VueloDto> Handle(GetVueloByIdQuery request, CancellationToken cancellationToken)
        {
            VueloDto result = null;
            try
            {
                Vuelo objVuelo = await _vueloRepository.FindByIdAsync(request.Id);
                result = new VueloDto()
                {
                    Id = objVuelo.Id,
                    NroItinerario = objVuelo.NroItinerario,
                    FechaInicio = objVuelo.FechaInicio,
                    FechaFinal = objVuelo.FechaFinal
                };
                foreach (var item in objVuelo.VuelosProgramados)
                {
                    result.VueloProgramado.Add(new VueloProgramadoDto()
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
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener Itinerario con id: { VueloId }", request.Id);    //!!! ver. el VueloId
            }
            return result;
        }
    }
}
