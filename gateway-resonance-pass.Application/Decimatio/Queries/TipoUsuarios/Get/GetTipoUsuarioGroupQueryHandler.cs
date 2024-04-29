namespace gateway_resonance_pass.Application.Decimatio.Queries.TipoUsuarios.Get
{
    public class GetTipoUsuarioGroupQueryHandler : IRequestHandler<GetTipoUsuarioGroupQuery, ApiResponse<GetTipoUsuarioGroupQueryResult>>
    {
        private readonly IDecimatioRepository _decimatioRepository;

        public GetTipoUsuarioGroupQueryHandler(IDecimatioRepository decimatioRepository)
        {
            _decimatioRepository = decimatioRepository;       
        }

        public async Task<ApiResponse<GetTipoUsuarioGroupQueryResult>> Handle(GetTipoUsuarioGroupQuery request, CancellationToken cancellationToken)
        {
            return await _decimatioRepository.GetTiposUsuariosGroup();   
        }
    }
}
