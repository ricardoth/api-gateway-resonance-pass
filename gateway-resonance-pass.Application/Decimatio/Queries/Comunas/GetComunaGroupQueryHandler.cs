using gateway_resonance_pass.Domain.Entities;

namespace gateway_resonance_pass.Application.Decimatio.Queries.Comunas
{
    public class GetComunaGroupQueryHandler : IRequestHandler<GetComunaGroupQuery, ApiResponse<GetComunaGroupQueryResult>>
    {
        private readonly IDecimatioRepository _decimatioRepository;

        public GetComunaGroupQueryHandler(IDecimatioRepository decimatioRepository)
        {
            _decimatioRepository = decimatioRepository;           
        }

        public Task<ApiResponse<GetComunaGroupQueryResult>> Handle(GetComunaGroupQuery request, CancellationToken cancellationToken)
        {
            return _decimatioRepository.GetComunasGroup(request);
        }
    }
}
