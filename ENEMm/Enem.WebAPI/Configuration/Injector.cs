﻿using Enem.WebAPI.Data;
using Enem.WebAPI.Repositories;
using Enem.WebAPI.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enem.WebAPI.Configuration
{
    public static class Injector
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<DataContext>();

            // services
            services.AddScoped<ICandidatoService, CandidatoService>();

            // repositories
            services.AddScoped<ICandidatoRepository, CandidatoRepository>();
        }
    }
}
