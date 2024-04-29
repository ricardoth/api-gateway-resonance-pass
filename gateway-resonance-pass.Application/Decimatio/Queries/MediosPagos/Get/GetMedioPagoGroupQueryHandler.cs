namespace gateway_resonance_pass.Application.Decimatio.Queries.MediosPagos.Get
{
    public class GetMedioPagoGroupQueryHandler : IRequestHandler<GetMedioPagoGroupQuery, ApiResponse<GetMedioPagoGroupQueryResult>>
    {
        private readonly IDecimatioRepository _decimatioRepository;

        public GetMedioPagoGroupQueryHandler(IDecimatioRepository decimatioRepository)
        {
            _decimatioRepository = decimatioRepository;    
        }

        public async Task<ApiResponse<GetMedioPagoGroupQueryResult>> Handle(GetMedioPagoGroupQuery request, CancellationToken cancellationToken)
        {
            return await _decimatioRepository.GetMediosPagosGroup();
        }
    }
}
