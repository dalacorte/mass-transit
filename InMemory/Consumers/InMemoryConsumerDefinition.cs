namespace Company.Consumers
{
    using MassTransit;

    public class InMemoryConsumerDefinition :
        ConsumerDefinition<InMemoryConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<InMemoryConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}