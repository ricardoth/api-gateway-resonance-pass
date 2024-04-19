namespace gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetPage
{
    public class GetPageEventoGroupQuery : IRequest<ApiResponse<GetPageEventoGroupQueryResult>>
    {
        public GetPageEventoGroupQuery(int idEvento, int pageSize, int pageNumber)
        {
            IdEvento = idEvento;
            PageNumber = pageNumber;
            PageSize = pageSize;    
        }

        public int IdEvento { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

    }
}
