namespace gateway_resonance_pass.Infraestructure.Extensions
{
    public static class BuilderServiceExtension
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDecimatioRepository, DecimatioRepository>();
        }
    }
}
