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
        Task<ApiResponse<GetEventoFilterGroupQueryResult>> GetEventosFilterGroup(GetEventoFilterGroupQuery request);

        #endregion

        #region Tipo Usuario
        Task<ApiResponse<GetTipoUsuarioGroupQueryResult>> GetTiposUsuariosGroup();
        #endregion

        #region Medios de Pago
        Task<ApiResponse<GetMedioPagoGroupQueryResult>> GetMediosPagosGroup();
        Task<ApiResponseObject<GetMedioPagoByIdQueryResult>> GetMedioPagoById(GetMedioPagoByIdQuery request);
        #endregion
    }
}
