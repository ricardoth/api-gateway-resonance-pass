namespace gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetById
{
    public class GetEventoByIdQueryHandler : IRequestHandler<GetEventoByIdQuery, ApiResponseObject<GetEventoByIdQueryResult>>
    {
        private readonly IDecimatioRepository _decimatioRepository;

        public GetEventoByIdQueryHandler(IDecimatioRepository decimatioRepository)
        {
            _decimatioRepository = decimatioRepository;       
        }

        public async Task<ApiResponseObject<GetEventoByIdQueryResult>> Handle(GetEventoByIdQuery request, CancellationToken cancellationToken)
        {
            return await _decimatioRepository.GetEventosById(request);
        }
    }
}
