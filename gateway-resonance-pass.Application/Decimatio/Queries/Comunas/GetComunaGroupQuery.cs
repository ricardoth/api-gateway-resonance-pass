using gateway_resonance_pass.Domain.Entities;

namespace gateway_resonance_pass.Application.Decimatio.Queries.Comunas
{
    public class GetComunaGroupQuery : IRequest<ApiResponse<GetComunaGroupQueryResult>>
    {
        public GetComunaGroupQuery(int idRegion)
        {
            IdRegion = idRegion;   
        }

        public int IdRegion { get; set; }
    }
}
