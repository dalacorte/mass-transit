namespace InMemory
{
    using MassTransit;
    using Microsoft.Extensions.Hosting;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class Worker : BackgroundService
    {
        readonly IBus _bus;
        public Worker(IBus bus)
        {
            _bus = bus;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await _bus.Publish(new Contracts.InMemory { Value = $"The time is {DateTimeOffset.Now}" }, stoppingToken);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
