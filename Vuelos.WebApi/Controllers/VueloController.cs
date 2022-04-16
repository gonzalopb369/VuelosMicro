using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelos;
using Vuelos.Application.UseCases.Command.Vuelos;
using Vuelos.Application.UseCases.Queries.Vuelos.GetVueloById;
using Vuelos.Application.UseCases.Queries.Vuelos.SearchVuelos;


namespace Vuelos.WebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class VueloController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VueloController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearVueloCommand command)
        {
            Guid id = await _mediator.Send(command);
            if (id == Guid.Empty)
                return BadRequest();
            return Ok(id);
        }


        [Route("{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> GetVueloById([FromRoute] GetVueloByIdQuery command)
        {
            VueloDto result = await _mediator.Send(command);
            if (result == null)
                return NotFound();
            return Ok(result);
        }


        [Route("search")]
        [HttpPost]
        public async Task<IActionResult> Search([FromBody] SearchVuelosQuery query)
        {
            var vuelo = await _mediator.Send(query);
            if (vuelo == null)
                return BadRequest();
            return Ok(vuelo);
        }
    }
}
