using gateway_resonance_pass.Application.Extensions;
using gateway_resonance_pass.Domain.ValueObjects;
using gateway_resonance_pass.Infraestructure.Extensions;
using System.Reflection;

namespace gateway_resonance_pass.Api.Configuration
{
    public static class DependencyConfiguration
    {
        public static void UseDependencyInjectionConfiguration(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddMediatR(conf => conf.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            //service.AddControllers(opt =>
            //{
            //    opt.Filters.Add(new ApiExceptionFilterAttribute());
            //});

            var config = configuration.GetSection(nameof(GatewayConfig)).Get<GatewayConfig>();
            service.AddSingleton(config);

            service.AddCQRS();
            service.AddDependencyInjection(configuration);

        }
    }
}
