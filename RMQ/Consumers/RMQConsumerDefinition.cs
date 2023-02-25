namespace Company.Consumers
{
    using MassTransit;

    public class RMQConsumerDefinition :
        ConsumerDefinition<RMQConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<RMQConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}