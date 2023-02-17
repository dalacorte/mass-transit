namespace Company.Consumers
{
    using Contracts;
    using MassTransit;
    using Microsoft.Extensions.Logging;
    using System.Threading.Tasks;

    public class InMemoryConsumer : IConsumer<InMemory>
    {
        readonly ILogger<InMemoryConsumer> _logger;
        public InMemoryConsumer(ILogger<InMemoryConsumer> logger)
        {
            _logger = logger;
        }
        public Task Consume(ConsumeContext<InMemory> context)
        {
            _logger.LogInformation("Received Text: {Text}", context.Message.Value);
            return Task.CompletedTask;
        }
    }
}