using Flurl.Http;
using gateway_resonance_pass.Application.Decimatio.Queries.Comunas;

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
                return Config.Url.WithHeader("Basic", Config.UserBasicAuth + Config.PassBasicAuth);
            }
        }

        #region Decimatio Actions

        public async Task<List<GetComunaGroupQueryResult>> GetComunasGroup(GetComunaGroupQuery request)
        {
            var response = await Url.AppendPathSegments("Decimatio", "GetComunas")
                                .AllowAnyHttpStatus()
                                .GetJsonAsync<List<GetComunaGroupQueryResult>>();
            return response;
        }
        #endregion
    }
}
