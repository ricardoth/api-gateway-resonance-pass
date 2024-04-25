using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetById;

namespace gateway_resonance_pass.Application.Interfaces
{
    public interface IDecimatioRepository
    {
        #region Comuna
        Task<ApiResponse<GetComunaGroupQueryResult>> GetComunasGroup(GetComunaGroupQuery request);
        #endregion

        #region Evento
        Task<ApiResponse<GetEventoGroupQueryResult>> GetEventosGroup();
        Task<ApiResponse<GetPageEventoGroupQueryResult>> GetPageEventosGroup(GetPageEventoGroupQuery request);
        Task<ApiResponseObject<GetEventoByIdQueryResult>> GetEventosById(GetEventoByIdQuery request);

        #endregion
    }
}
