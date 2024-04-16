using gateway_resonance_pass.Application.Decimatio.Queries.Comunas;
using Microsoft.Extensions.DependencyInjection;

namespace gateway_resonance_pass.Application.Extensions
{
    public static class DependencyConfiguration
    {
        public static void AddCQRS(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<GetComunaGroupQuery, List<GetComunaGroupQueryResult>>, GetComunaGroupQueryHandler>();
        }
    }
}
