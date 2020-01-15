using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace Enem.WebAPI.Configuration
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "EnemAPP", Version = "v1" });
            });
        }

    }
}


