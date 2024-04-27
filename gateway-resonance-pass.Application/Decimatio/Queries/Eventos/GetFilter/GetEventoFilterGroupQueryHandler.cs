namespace gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetFilter
{
    public class GetEventoFilterGroupQueryHandler : IRequestHandler<GetEventoFilterGroupQuery, ApiResponse<GetEventoFilterGroupQueryResult>>
    {
        private readonly IDecimatioRepository _decimatioRepository;

        public GetEventoFilterGroupQueryHandler(IDecimatioRepository decimatioRepository)
        {
            _decimatioRepository = decimatioRepository;        
        }

        public async Task<ApiResponse<GetEventoFilterGroupQueryResult>> Handle(GetEventoFilterGroupQuery request, CancellationToken cancellationToken)
        {
            return await _decimatioRepository.GetEventosFilterGroup(request);
        }
    }
}
