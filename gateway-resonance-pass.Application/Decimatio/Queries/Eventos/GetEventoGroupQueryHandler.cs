
namespace gateway_resonance_pass.Application.Decimatio.Queries.Eventos
{
    public class GetEventoGroupQueryHandler : IRequestHandler<GetEventoGroupQuery, ApiResponse<GetEventoGroupQueryResult>>
    {
        private readonly IDecimatioRepository _decimatioRepository;

        public GetEventoGroupQueryHandler(IDecimatioRepository decimatioRepository)
        {
            _decimatioRepository = decimatioRepository; 
        }

        public async Task<ApiResponse<GetEventoGroupQueryResult>> Handle(GetEventoGroupQuery request, CancellationToken cancellationToken)
        {
            return await _decimatioRepository.GetEventosGroup();
        }
    }
}
