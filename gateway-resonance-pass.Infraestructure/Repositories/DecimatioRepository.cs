using Flurl.Http;

namespace gateway_resonance_pass.Infraestructure.Repositories
{
    public sealed class DecimatioRepository : IDecimatioRepository
    {
        private GatewayConfigItemDecimatio Config { get;  }

        public DecimatioRepository(GatewayConfig config)
        {
            Config = config.ApiDecimatio;
            Config.UserBasicAuth = Config.UserBasicAuth ?? config.UrlBasicAuth;
        }

        private IFlurlRequest Url
        {
            get
            {
                return Config.Url.WithHeader("Basic", Config.UserBasicAuth + Config.PassBasicAuth);
            }
        }

        #region Decimatio Actions


        #endregion
    }
}
