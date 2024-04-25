﻿using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetAll;
using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetById;
using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetPage;

namespace gateway_resonance_pass.Infraestructure.Repositories
{
    public sealed class DecimatioRepository : IDecimatioRepository
    {
        private GatewayConfigItemDecimatio Config { get;  }

        public DecimatioRepository(GatewayConfig config)
        {
            Config = config.ApiDecimatio;
            Config.UserBasicAuth = Config.UserBasicAuth ?? config.UserBasicAuth;
        }

        private IFlurlRequest Url
        {
            get
            {
                string credentials = $"{Config.UserBasicAuth}:{Config.PassBasicAuth}";
                string encodingCredentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials));
                return Config.Url.WithHeader("Authorization", $"Basic {encodingCredentials}");
            }
        }

        #region Decimatio Actions

        public async Task<ApiResponse<GetComunaGroupQueryResult>> GetComunasGroup(GetComunaGroupQuery request)
        {
            try
            {
                var response = await Url.AppendPathSegments("Comuna", request.IdRegion)
                          .AllowAnyHttpStatus()
                          .GetAsync();

                if (response.StatusCode != 200)
                {
                    throw new BadRequestException("Error en la solicitud HTTP");
                }

                var responseContent = await response.GetStringAsync();
                var comunas = JsonConvert.DeserializeObject<ApiResponse<GetComunaGroupQueryResult>>(responseContent);
                return comunas;
            }
            catch (Exception ex)
            {
                throw new BadRequestException("Hubo un error en llamar a las comunas");
            }
      
        }

        public async Task<ApiResponse<GetEventoGroupQueryResult>> GetEventosGroup()
        {
            try
            {
                var response = await Url.AppendPathSegments("Evento")
                    .AllowAnyHttpStatus()
                    .GetAsync();

                if (response.StatusCode != 200)
                {
                    throw new BadRequestException("Error en la solicitud HTTP");
                }

                var responseContent = await response.GetStringAsync();
                var eventos = JsonConvert.DeserializeObject<ApiResponse<GetEventoGroupQueryResult>>(responseContent);
                return eventos;
            }
            catch (Exception ex)
            {
                throw new BadRequestException("Hubo un error en llamar a las comunas");
            }
        }

        public async Task<ApiResponse<GetPageEventoGroupQueryResult>> GetPageEventosGroup(GetPageEventoGroupQuery request)
        {
            try
            {
                var response = await Url.AppendPathSegments("Evento", "GetEventosPagination")
                    .AllowAnyHttpStatus()
                    .SetQueryParams(request)
                    .GetAsync();

                if (response.StatusCode != 200)
                {
                    throw new BadRequestException("Error en la solicitud HTTP");
                }

                var responseContent = await response.GetStringAsync();
                var eventos = JsonConvert.DeserializeObject<ApiResponse<GetPageEventoGroupQueryResult>>(responseContent);
                return eventos;
            }
            catch (FlurlHttpException ex)
            {
                throw new BadRequestException("Hubo un error en llamar a las comunas"); 
            }
        }

        public async Task<ApiResponseObject<GetEventoByIdQueryResult>> GetEventosById(GetEventoByIdQuery request)
        {
            try
            {
                var response = await Url.AppendPathSegments("Evento", request.IdEvento)
                    .AllowAnyHttpStatus()
                    .GetAsync();

                if (response.StatusCode != 200) 
                    throw new BadRequestException("Error en la solicitud HTTP");

                var responseContent = await response.GetStringAsync();
                var evento = JsonConvert.DeserializeObject<ApiResponseObject<GetEventoByIdQueryResult>>(responseContent);
                return evento;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion
    }
}
