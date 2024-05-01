namespace gateway_resonance_pass.Application.Decimatio.Queries.Regiones.Get
{
    public class GetRegionGroupQueryHandler : IRequestHandler<GetRegionGroupQuery, ApiResponse<GetRegionGroupQueryResult>>
    {
        private readonly IDecimatioRepository _decimatioRepository;

        public GetRegionGroupQueryHandler(IDecimatioRepository decimatioRepository)
        {
            _decimatioRepository = decimatioRepository;    
        }

        public async Task<ApiResponse<GetRegionGroupQueryResult>> Handle(GetRegionGroupQuery request, CancellationToken cancellationToken)
        {
            return await _decimatioRepository.GetRegionesGroup();
        }
    }
}
