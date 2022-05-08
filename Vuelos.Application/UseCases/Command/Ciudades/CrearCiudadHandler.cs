using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vuelos.Application.Services;
using Vuelos.Domain.Factories;
using Vuelos.Domain.Repositories;
using Vuelos.Domain.Model.Ciudades;


namespace Vuelos.Application.UseCases.Command.Ciudades
{
    public class CrearCiudadHandler : IRequestHandler<CrearCiudadCommand, Guid>
    {
        private readonly ICiudadRepository _ciudadRepository;
        private readonly ILogger<CrearCiudadHandler> _logger;
        private readonly ICiudadService _ciudadService;
        private readonly ICiudadFactory _ciudadFactory;
        private readonly IUnitOfWork _unitOfWork;


        public CrearCiudadHandler(ICiudadRepository ciudadRepository, ILogger<CrearCiudadHandler> logger,
                        ICiudadService ciudadService, ICiudadFactory ciudadFactory, IUnitOfWork unitOfWork)
        {
            _ciudadRepository = ciudadRepository;
            _logger = logger;
            _ciudadService = ciudadService;
            _ciudadFactory = ciudadFactory;
            _unitOfWork = unitOfWork;
        }


        public async Task<Guid> Handle(CrearCiudadCommand request, CancellationToken cancellationToken)
        {
            try
            {
                string codigoCiudad = await _ciudadService.GenerarNroCiudadAsync();  // crea ciudad vacia
                //Aeronave objAeronave = _aeronaveFactory.Create(nroAeronave); ORIGINAL
                Ciudad objCiudad = _ciudadFactory.CrearCiudad(request.CodigoCiudad, request.NombreCiudad,
                    request.NombreAeropuerto, request.EstadoAeropuerto);                            
                //foreach (var item in request.DetalleAsientos)
                //{
                //    objAeronave.AgregarItem(item.NroAsiento, item.Fila, item.Columna, item.EstadoAsiento);
                //}
                objCiudad.ConsolidarCiudad();
                await _ciudadRepository.CreateAsync(objCiudad);    // para persistir 
                await _unitOfWork.Commit();
                return objCiudad.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear la Ciudad");
            }
            return Guid.Empty;
        }

    }
}
