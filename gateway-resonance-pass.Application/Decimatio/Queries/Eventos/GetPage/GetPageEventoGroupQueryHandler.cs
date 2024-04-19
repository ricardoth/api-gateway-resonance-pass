namespace gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetPage
{
    public class GetPageEventoGroupQueryHandler : IRequestHandler<GetPageEventoGroupQuery, ApiResponse<GetPageEventoGroupQueryResult>>
    {
        private readonly IDecimatioRepository _decimatioRepository;

        public GetPageEventoGroupQueryHandler(IDecimatioRepository decimatioRepository)
        {
            _decimatioRepository = decimatioRepository;
        }

        public async Task<ApiResponse<GetPageEventoGroupQueryResult>> Handle(GetPageEventoGroupQuery request, CancellationToken cancellationToken)
        {
            return await _decimatioRepository.GetPageEventosGroup(request);
        }
    }
}
