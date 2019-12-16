using System;

namespace Simple_Shop.Domain.Events.Interfaces
{
    public interface IDomainEvent
    {
        DateTime DateOccured { get; set; }
    }
}
