﻿using Enem.WebAPI.Data;
using Enem.WebAPI.Repositories;
using Enem.WebAPI.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enem.WebAPI.Data.Repositories;
using Enem.WebAPI.Data.Repositories.Interfaces;
using Enem.WebAPI.FluentValidation;
using Enem.WebAPI.Models;
using Enem.WebAPI.Services.Interfaces;
using FluentValidation;

namespace Enem.WebAPI.Configuration
{
    public static class Injector
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<DataContext>();

            // services
            services.AddScoped<ICandidatoService, CandidatoService>();
            
            services.AddScoped<IConcursoService, ConcursoService>();

            // repositories
            services.AddScoped<ICandidatoRepository, CandidatoRepository>();

            services.AddScoped<IConcursoRepository, ConcursoRepository>();


            services.AddTransient<IValidator<Candidato>, CandidatoValidator>();


        }
    }
}
