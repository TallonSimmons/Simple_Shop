using System.Threading.Tasks;

namespace Simple_Shop.Domain.Events.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}
