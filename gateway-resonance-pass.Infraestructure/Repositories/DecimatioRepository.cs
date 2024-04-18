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
                    throw new Exception("Error en la solicitud HTTP");
                }

                var responseContent = await response.GetStringAsync();
                var deszerialize = JsonConvert.DeserializeObject<ApiResponse<GetComunaGroupQueryResult>>(responseContent);

                return deszerialize;

            }
            catch (Exception ex)
            {
                throw new Exception("Hubo un error en llamar a las comunas");
            }
      
        }
        #endregion
    }
}
