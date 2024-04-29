using gateway_resonance_pass.Application.Decimatio.Queries.Comunas.Get;
using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetById;
using gateway_resonance_pass.Application.Decimatio.Queries.Eventos.GetFilter;
using gateway_resonance_pass.Application.Decimatio.Queries.MediosPagos.Get;
using gateway_resonance_pass.Application.Decimatio.Queries.TipoUsuarios.Get;

namespace gateway_resonance_pass.Application.Extensions
{
    public static class DependencyConfiguration
    {
        public static void AddCQRS(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<GetComunaGroupQuery, ApiResponse<GetComunaGroupQueryResult>>, GetComunaGroupQueryHandler>();
            services.AddScoped<IRequestHandler<GetEventoGroupQuery, ApiResponse<GetEventoGroupQueryResult>>, GetEventoGroupQueryHandler>();
            services.AddScoped<IRequestHandler<GetPageEventoGroupQuery, ApiResponse<GetPageEventoGroupQueryResult>>, GetPageEventoGroupQueryHandler>();
            services.AddScoped<IRequestHandler<GetEventoByIdQuery, ApiResponseObject<GetEventoByIdQueryResult>>, GetEventoByIdQueryHandler>();
            services.AddScoped<IRequestHandler<GetEventoFilterGroupQuery, ApiResponse<GetEventoFilterGroupQueryResult>>, GetEventoFilterGroupQueryHandler>();
            services.AddScoped<IRequestHandler<GetTipoUsuarioGroupQuery, ApiResponse<GetTipoUsuarioGroupQueryResult>>, GetTipoUsuarioGroupQueryHandler>();
            services.AddScoped<IRequestHandler<GetMedioPagoGroupQuery, ApiResponse<GetMedioPagoGroupQueryResult>>, GetMedioPagoGroupQueryHandler>();
        }
    }
}
