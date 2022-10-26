namespace Company.Consumers
{
    using MassTransit;

    public class ServiceConsumerConsumerDefinition :
        ConsumerDefinition<ServiceConsumerConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<ServiceConsumerConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}