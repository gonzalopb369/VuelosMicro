using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Aeronave;
using Vuelos.Application.UseCases.Command.Aeronaves;
using Vuelos.Application.UseCases.Queries.Aeronaves.GetAeronaveById;
using Vuelos.Application.UseCases.Queries.Aeronaves.SearchAeronaves;

namespace Vuelos.WebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AeronaveController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AeronaveController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearAeronaveCommand command)    // CrearAeronaveCommand = Request
        {
            Guid id = await _mediator.Send(command);
            if (id == Guid.Empty)
                return BadRequest();
            return Ok(id);
        }


        [Route("{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> GetAeronaveById([FromRoute] GetAeronaveByIdQuery command)
        {
            AeronaveDto result = await _mediator.Send(command);
            if (result == null)
                return NotFound();
            return Ok(result);
        }


        [Route("search")]
        [HttpPost]
        public async Task<IActionResult> Search([FromBody] SearchAeronavesQuery query)
        {
            var aeronaves = await _mediator.Send(query);
            if (aeronaves == null)
                return BadRequest();
            return Ok(aeronaves);
        }
    }
}

    
