namespace gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetFilter
{
    public class GetEventoFilterGroupQuery : IRequest<ApiResponse<GetEventoFilterGroupQueryResult>>
    {
        public GetEventoFilterGroupQuery(string filtro)
        {
            Filtro = filtro;       
        }
        public string Filtro { get; set; }
    }
}
