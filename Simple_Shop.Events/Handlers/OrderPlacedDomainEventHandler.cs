using Simple_Shop.Domain.Events;
using Simple_Shop.Domain.Events.Interfaces;
using System.Threading.Tasks;

namespace Simple_Shop.Events.Handlers
{
    public class OrderPlacedDomainEventHandler : IHandle<OrderPlacedEvent>
    {
        public Task Handle(OrderPlacedEvent domainEvent)
        {
            // In handlers such as this, we can take care of any domain event side effects. And, if required, can even create multiple types (handlers) per event.
            // E.g. a handler for calling a cloud function to send an invoice email; a handler for publishing a message to a bus; etc.
            return Task.CompletedTask;
        }
    }
}
