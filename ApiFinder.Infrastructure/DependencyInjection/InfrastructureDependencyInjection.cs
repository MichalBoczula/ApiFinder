using ApiFinder.Infrastructure.ExternalServices.Abstract;
using ApiFinder.Infrastructure.ExternalServices.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace ApiFinder.Infrastructure.DependencyInjection
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IExternalServiceRequestHandler, ExternalServiceRequestHandler>();
            return services;
        }
    }
}
