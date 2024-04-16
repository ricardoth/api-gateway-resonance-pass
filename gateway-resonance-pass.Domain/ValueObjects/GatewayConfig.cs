namespace gateway_resonance_pass.Domain.ValueObjects
{
    public class GatewayConfig
    {
        public string SubscriptionKey { get; set; }
        public string UrlBasicAuth { get; set; }
        public string PassBasicAuth { get; set; }
        public bool ValidateIdentification { get; set; }
        public GatewayConfigItemDecimatio ApiDecimatio { get; set; }
        public GatewayConfigItemIdentification ApiIdentification { get; set; }

    }

    public class GatewayConfigItemDecimatio
    {
        public string UserBasicAuth { get; set;}
        public string PassBasicAuth { get; set;}
        public string Url { get; set; } 
    }

    public class GatewayConfigItemIdentification
    {
        public string Token { get; set; }
        public string Url { get; set; }
    }
}
