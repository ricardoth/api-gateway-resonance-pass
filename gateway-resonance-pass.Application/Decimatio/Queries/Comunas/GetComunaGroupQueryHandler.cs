namespace gateway_resonance_pass.Application.Decimatio.Queries.Comunas
{
    public class GetComunaGroupQueryHandler : IRequestHandler<GetComunaGroupQuery, GetComunaGroupQueryResult>
    {
        private readonly IDecimatioRepository _decimatioRepository;

        public GetComunaGroupQueryHandler(IDecimatioRepository decimatioRepository)
        {
            _decimatioRepository = decimatioRepository;           
        }

        public Task<GetComunaGroupQueryResult> Handle(GetComunaGroupQuery request, CancellationToken cancellationToken)
        {
            return _decimatioRepository.GetComunasGroup(request);
        }
    }
}
