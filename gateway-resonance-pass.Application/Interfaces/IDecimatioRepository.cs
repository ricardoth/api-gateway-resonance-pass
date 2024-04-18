namespace gateway_resonance_pass.Application.Interfaces
{
    public interface IDecimatioRepository
    {
        Task<ApiResponse<GetComunaGroupQueryResult>> GetComunasGroup(GetComunaGroupQuery request);
    }
}
