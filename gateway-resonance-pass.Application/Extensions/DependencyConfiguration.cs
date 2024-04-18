using gateway_resonance_pass.Application.Decimatio.Queries.Eventos;

namespace gateway_resonance_pass.Application.Extensions
{
    public static class DependencyConfiguration
    {
        public static void AddCQRS(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<GetComunaGroupQuery, ApiResponse<GetComunaGroupQueryResult>>, GetComunaGroupQueryHandler>();
            services.AddScoped<IRequestHandler<GetEventoGroupQuery, ApiResponse<GetEventoGroupQueryResult>>, GetEventoGroupQueryHandler>();
        }
    }
}
