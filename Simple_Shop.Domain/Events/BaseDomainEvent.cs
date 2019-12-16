using Simple_Shop.Domain.Events.Interfaces;
using System;

namespace Simple_Shop.Domain.Events
{
    public abstract class BaseDomainEvent : IDomainEvent
    {
        public DateTime DateOccured { get; set; } = DateTime.UtcNow;
    }
}
