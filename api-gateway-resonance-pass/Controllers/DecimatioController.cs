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
        public async Task<ApiResponse<GetComunaGroupQueryResult>> GetComunaQueryGroup(int idRegion) => await _mediator.Send(new GetComunaGroupQuery(idRegion));
       
        [HttpGet("eventos")]
        public async Task<ApiResponse<GetEventoGroupQueryResult>> GetEventoQueryGroup() => await _mediator.Send(new GetEventoGroupQuery());

        [HttpGet("eventos/page")]
        public async Task<ApiResponse<GetPageEventoGroupQueryResult>> GetPageEventoQueryGroup([FromQuery] EventoFilters filters) => await _mediator.Send(new GetPageEventoGroupQuery(filters.IdEvento, filters.PageSize, filters.PageNumber));

        [HttpGet("eventos/{id}")]
        public async Task<ApiResponseObject<GetEventoByIdQueryResult>> GetEventoById(int id) => await _mediator.Send(new GetEventoByIdQuery(id));
  
        [HttpGet("eventos/filter")]
        public async Task<ApiResponse<GetEventoFilterGroupQueryResult>> GetEventosFilterQueryGroup([FromQuery] string filter) => await _mediator.Send(new GetEventoFilterGroupQuery(filter));
  
        [HttpGet("tiposUsuarios")]
        public async Task<ApiResponse<GetTipoUsuarioGroupQueryResult>> GetTiposUsuarioQueryGroup() => await _mediator.Send(new GetTipoUsuarioGroupQuery());

        [HttpGet("mediosPago")]
        public async Task<ApiResponse<GetMedioPagoGroupQueryResult>> GetMediosPagosQueryGroup() => await _mediator.Send(new GetMedioPagoGroupQuery());

        [HttpGet("mediosPago/{id}")]
        public async Task<ApiResponseObject<GetMedioPagoByIdQueryResult>> GetMedioPagoById(int id) => await _mediator.Send(new GetMedioPagoByIdQuery(id));
    }
}
