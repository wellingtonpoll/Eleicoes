using System.Text.Json.Serialization;
using Eleicoes.Services.API.Configurations;
using Eleicoes.Services.API.MiddleWares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace Eleicoes.Services.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddJsonOptions(opts =>
                    {
                        opts.JsonSerializerOptions.IgnoreNullValues = true;
                        opts.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                    });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Eleicoes API", Version = "v1" });
            });
            services.AddHealthChecks();
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddAutoMapperSetup();
            services.AddDependencyInjectionSetup();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            // if (env.IsDevelopment())
            //     app.UseDeveloperExceptionPage();
            app.UseGlobalExceptionHandler(loggerFactory);

            app.UseSwagger();
            app.UseSwaggerUI(c => 
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Eleições");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealthChecks("/health");
            });
        }
    }
}
