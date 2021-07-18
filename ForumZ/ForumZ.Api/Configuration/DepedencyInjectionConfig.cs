using ForumZ.Infraestructure.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumZ.Api.Configuration
{
    public static class DepedencyInjectionConfig
    {
        public static IServiceCollection ResolveDependences(this IServiceCollection services)
        {
            services.AddSingleton<MyDbContext>();

            return services;
        }
    }
}
