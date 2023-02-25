namespace Company.Consumers
{
    using Contracts;
    using MassTransit;
    using Microsoft.Extensions.Logging;
    using System.Threading.Tasks;

    public class RMQConsumer :
        IConsumer<RMQ>
    {
        private readonly ILogger<RMQConsumer> _logger;
        public RMQConsumer(ILogger<RMQConsumer> logger)
        {
            _logger = logger;
        }
        public Task Consume(ConsumeContext<RMQ> context)
        {
            _logger.LogInformation("Received Text: {Text}", context.Message.Value);
            return Task.CompletedTask;
        }
    }
}