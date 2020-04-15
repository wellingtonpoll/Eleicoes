using System;
using System.Threading;
using System.Threading.Tasks;
using Eleicoes.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Eleicoes.Application.Services
{
    public class CandidatoImportHostedService : IHostedService, IDisposable
    {
        private readonly ILogger<CandidatoImportHostedService> _logger;
        private Timer _timer;
        private IServiceProvider Services { get; }
        
        public CandidatoImportHostedService(
            ILogger<CandidatoImportHostedService> logger,
            IServiceProvider services)
        {
            _logger = logger;
            Services = services;
        }

        private void DoWork(Object stateInfo)
        {
            using (var scope = Services.CreateScope())
            {
                var scopedProcessingService = 
                    scope.ServiceProvider
                        .GetRequiredService<ICandidatoImportService>();

                scopedProcessingService.DoWork();
            }
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(30));
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}