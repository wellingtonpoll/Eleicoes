using System;
using Eleicoes.Application.Interfaces;
using Eleicoes.Application.Services;
using Eleicoes.Domain.Interfaces;
using Eleicoes.Domain.Services;
using Eleicoes.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Eleicoes.Services.API.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddSingleton<ICandidatoRepository, CandidatoRepository>();
            services.AddSingleton<ICandidatoAppService, CandidatoAppService>();
            services.AddScoped<ICandidatoImportService, CandidatoImportService>();
            services.AddHostedService<CandidatoImportHostedService>();
        }
    }
}