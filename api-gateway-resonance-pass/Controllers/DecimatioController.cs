using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetAll;
using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetById;
using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetFilter;
using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetPage;
using gateway_resonance_pass.Application.Decimatio.Queries.TipoUsuarios.Get;

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

        [HttpGet("eventos/{id}")]
        public async Task<ApiResponseObject<GetEventoByIdQueryResult>> GetEventoById(int id)
        {
            return await _mediator.Send(new GetEventoByIdQuery(id));
        }

        [HttpGet("eventos/filter")]
        public async Task<ApiResponse<GetEventoFilterGroupQueryResult>> GetEventosFilterQueryGroup([FromQuery] string filter)
        {
            return await _mediator.Send(new GetEventoFilterGroupQuery(filter));
        }

        [HttpGet("tiposUsuarios")]
        public async Task<ApiResponse<GetTipoUsuarioGroupQueryResult>> GetTiposUsuarioQueryGroup()
        {
            return await _mediator.Send(new GetTipoUsuarioGroupQuery());
        }
    }
}
