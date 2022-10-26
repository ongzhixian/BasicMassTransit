namespace Company.Consumers
{
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;

    public class ServiceConsumerConsumer :
        IConsumer<ServiceConsumer>
    {
        public Task Consume(ConsumeContext<ServiceConsumer> context)
        {
            return Task.CompletedTask;
        }
    }
}