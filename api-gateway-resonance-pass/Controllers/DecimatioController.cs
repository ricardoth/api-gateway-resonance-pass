﻿using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetAll;
using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetPage;

namespace gateway_resonance_pass.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecimatioController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DecimatioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("comunas/{idRegion}")]
        public async Task<ApiResponse<GetComunaGroupQueryResult>> GetComunaQueryGroup(int idRegion)
        {
            return await _mediator.Send(new GetComunaGroupQuery(idRegion));
        }

        [HttpGet("eventos")]
        public async Task<ApiResponse<GetEventoGroupQueryResult>> GetEventoQueryGroup()
        {
            return await _mediator.Send(new GetEventoGroupQuery());
        }

        [HttpGet("eventos/page")]
        public async Task<ApiResponse<GetPageEventoGroupQueryResult>> GetPageEventoQueryGroup([FromQuery] EventoFilters filters)
        {
            return await _mediator.Send(new GetPageEventoGroupQuery(filters.IdEvento, filters.PageSize, filters.PageNumber));
        }
    }
}
