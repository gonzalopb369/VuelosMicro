using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Aeronave;
using Vuelos.Domain.Model.Aeronaves;
using Vuelos.Domain.Repositories;


namespace Vuelos.Application.UseCases.Queries.Aeronaves.GetAeronaveById
{
    public class GetAeronaveByIdHandler : IRequestHandler<GetAeronaveByIdQuery, AeronaveDto>
    {
        private readonly IAeronaveRepository _aeronaveRepository;
        private readonly ILogger<GetAeronaveByIdQuery> _logger;

        public GetAeronaveByIdHandler(IAeronaveRepository aeronaveRepository, ILogger<GetAeronaveByIdQuery> logger)
        {
            _aeronaveRepository = aeronaveRepository;
            _logger = logger;
        }

        public async Task<AeronaveDto> Handle(GetAeronaveByIdQuery request, CancellationToken cancellationToken)
        {
            AeronaveDto result = null;
            try
            {
                Aeronave objAeronave = await _aeronaveRepository.FindByIdAsync(request.Id);

                result = new AeronaveDto()
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

                //foreach (var item in objPedido.Detalle)
                //{
                //    result.Detalle.Add(new DetallePedidoDto()
                //    {
                //        Cantidad = item.Cantidad,
                //        Instrucciones = item.Instrucciones,
                //        Precio = item.Precio,
                //        ProductoId = item.ProductoId
                //    });
                //}
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener Aeronave con id: { AeronaveId }", request.Id);
            }
            return result;
        }
    }
}
