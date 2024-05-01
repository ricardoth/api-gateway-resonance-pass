namespace gateway_resonance_pass.Application.Decimatio.Queries.MediosPagos.GetById
{
    public class GetMedioPagoByIdQueryHandler : IRequestHandler<GetMedioPagoByIdQuery, ApiResponseObject<GetMedioPagoByIdQueryResult>>
    {
        private readonly IDecimatioRepository _decimatioRepository;

        public GetMedioPagoByIdQueryHandler(IDecimatioRepository decimatioRepository)
        {
            _decimatioRepository = decimatioRepository;    
        }

        public async Task<ApiResponseObject<GetMedioPagoByIdQueryResult>> Handle(GetMedioPagoByIdQuery request, CancellationToken cancellationToken)
        {
            return await _decimatioRepository.GetMedioPagoById(request);
        }
    }
}