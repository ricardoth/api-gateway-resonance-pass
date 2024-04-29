using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetAll;
using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetById;
using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetFilter;
using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetPage;
using gateway_resonance_pass.Application.Decimatio.Queries.TipoUsuarios.Get;

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

        #region Comunas

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
        #endregion

        #region Eventos
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
                throw new BadRequestException("Hubo un error en llamar a los eventos");
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
                throw new BadRequestException("Hubo un error en llamar a los eventos");
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
                throw new BadRequestException("Hubo un error al obtener el evento");
            }
        }

        public async Task<ApiResponse<GetEventoFilterGroupQueryResult>> GetEventosFilterGroup(GetEventoFilterGroupQuery request)
        {
            try
            {
                var response = await Url.AppendPathSegments("Evento", "GetEventosFilter")
                    .AllowAnyHttpStatus()
                    .SetQueryParams(request)
                    .GetAsync();

                if (response.StatusCode != 200)
                    throw new BadRequestException("Error en la solicitud HTTP");

                var responseContent = await response.GetStringAsync();
                var evento = JsonConvert.DeserializeObject<ApiResponse<GetEventoFilterGroupQueryResult>>(responseContent);
                return evento;
            }
            catch (Exception ex)
            {
                throw new BadRequestException("Hubo un error al obtener los eventos");
            }
        }
        #endregion

        #region Tipo Usuario
        public async Task<ApiResponse<GetTipoUsuarioGroupQueryResult>> GetTiposUsuariosGroup()
        {
            try
            {
                var response = await Url.AppendPathSegments("TipoUsuario")
                    .AllowAnyHttpStatus()
                    .GetAsync();

                if (response.StatusCode != 200)
                    throw new BadRequestException("Error en la solicitud HTTP");

                var responseContent = await response.GetStringAsync();
                var tiposUsuario = JsonConvert.DeserializeObject<ApiResponse<GetTipoUsuarioGroupQueryResult>>(responseContent);
                return tiposUsuario;

            }
            catch (Exception ex)
            {
                throw new BadRequestException("Hubo un error al obtener los tipos de usuarios");
            }
        }
        #endregion
    }
}
