namespace gateway_resonance_pass.Api.Configuration
{
    public static class DependencyConfiguration
    {
        public static void UseDependencyInjectionConfiguration(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddMediatR(conf => conf.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            var config = configuration.GetSection("GatewayConfig").Get<GatewayConfig>();
            service.AddSingleton(config);

            service.AddCQRS();
            service.AddDependencyInjection(configuration);

            service.AddTransient<GlobalExceptionFilterAttribute>();

        }
    }
}
