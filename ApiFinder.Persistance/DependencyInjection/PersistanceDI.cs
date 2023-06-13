using ApiFinder.Application.Contracts;
using ApiFinder.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinder.Persistance.DependencyInjection
{
    public static class PersistanceDI
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApiFinderContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Application"));
            });

            services.AddScoped<IApiFinderContext, ApiFinderContext>();

            return services;
        }
    }
}
