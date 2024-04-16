using gateway_resonance_pass.Application.Decimatio.Queries.Comunas;
namespace gateway_resonance_pass.Application.Interfaces
{
    public interface IDecimatioRepository
    {
        Task<GetComunaGroupQueryResult> GetComunasGroup(GetComunaGroupQuery request);
    }
}
