namespace gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetById
{
    public class GetEventoByIdQuery : IRequest<ApiResponseObject<GetEventoByIdQueryResult>>
    {
        public GetEventoByIdQuery(int idEvento)
        {
            IdEvento = idEvento;
        }

        public int IdEvento { get; set; }
    }
}
