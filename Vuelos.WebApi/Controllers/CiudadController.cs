using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Ciudad;
using Vuelos.Application.UseCases.Queries.Ciudades.GetCiudadByIdQuery;

namespace Vuelos.WebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CiudadController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CiudadController(IMediator mediator)
        {
            _mediator = mediator;
        }


        //[HttpPost]
        //public async Task<IActionResult> Create([FromBody] CrearAeronaveCommand command)    // CrearAeronaveCommand = Request
        //{
        //    Guid id = await _mediator.Send(command);
        //    if (id == Guid.Empty)
        //        return BadRequest();
        //    return Ok(id);
        //}


        [Route("{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> GetCiudadById([FromRoute] GetCiudadByIdQuery command)
        {
            CiudadDto result = await _mediator.Send(command);
            if (result == null)
                return NotFound();
            return Ok(result);
        }


        //[Route("search")]
        //[HttpPost]
        //public async Task<IActionResult> Search([FromBody] SearchAeronavesQuery query)
        //{
        //    var aeronaves = await _mediator.Send(query);
        //    if (aeronaves == null)
        //        return BadRequest();
        //    return Ok(aeronaves);
        //}


    }
}
