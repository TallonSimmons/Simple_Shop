using System.Threading.Tasks;

namespace Simple_Shop.Domain.Events.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}
