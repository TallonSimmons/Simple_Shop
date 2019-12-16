using Simple_Shop.Domain.Events;
using System.Collections.Generic;

namespace Simple_Shop.Domain.DataModels
{
    public abstract class BaseDTO 
    {
        public int Id { get; set; }

        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}
