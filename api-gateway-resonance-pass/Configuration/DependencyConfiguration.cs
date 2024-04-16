using gateway_resonance_pass.Api.Helpers;
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
        }
    }
}
