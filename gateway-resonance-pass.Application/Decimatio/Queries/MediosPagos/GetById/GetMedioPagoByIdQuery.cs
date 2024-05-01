namespace gateway_resonance_pass.Application.Decimatio.Queries.MediosPagos.GetById
{
    public class GetMedioPagoByIdQuery : IRequest<ApiResponseObject<GetMedioPagoByIdQueryResult>>
    {
        public GetMedioPagoByIdQuery(int idMedioPago)
        {
            IdMedioPago = idMedioPago;
        }

        public int IdMedioPago { get; set; }
    }
}
