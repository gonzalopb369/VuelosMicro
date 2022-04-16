using MediatR;
using Microsoft.Extensions.Logging;
using Pedidos.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vuelos.Domain.Factories;
using Vuelos.Domain.Repositories;
//using Vuelos.Domain.Model.Aeronaves;


namespace Pedidos.Application.UseCases.Command.Aeronave
{
    public class CrearAeronaveHandler : IRequestHandler<CrearAeronaveCommand, Guid>
    {
        private readonly IAeronaveRepository _aeronaveRepository;
        private readonly ILogger<CrearAeronaveHandler> _logger;
        private readonly IAeronaveService _aeronaveService;
        private readonly IAeronaveFactory _aeronaveFactory;
        private readonly IUnitOfWork _unitOfWork;


        public CrearAeronaveHandler(IAeronaveRepository aeronaveRepository, ILogger<CrearAeronaveHandler> logger,
                        IAeronaveService aeronaveService, IAeronaveFactory aeronaveFactory, IUnitOfWork unitOfWork)
        {
            _aeronaveRepository = aeronaveRepository;
            _logger = logger;
            _aeronaveService = aeronaveService;
            _aeronaveFactory = aeronaveFactory;
            _unitOfWork = unitOfWork;
        }


        public async Task<Guid> Handle(CrearAeronaveCommand request, CancellationToken cancellationToken)
        {
            try
            {
                string nroAeronave = await _aeronaveService.GenerarNroAeronaveAsync();
                Vuelos.Domain.Model.Aeronaves.Aeronave objAeronave = _aeronaveFactory.Create(nroAeronave);
                foreach (var item in request.DetalleAsientos)
                {
                    objAeronave.AgregarItem(item.NroAsiento, item.Fila, item.Columna, item.EstadoAsiento);
                }
                objAeronave.ConsolidarAeronave();
                await _aeronaveRepository.CreateAsync(objAeronave);    // para persistir 
                await _unitOfWork.Commit();
                return objAeronave.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear la Aeronave");
            }
            return Guid.Empty;
        }
    }
}
