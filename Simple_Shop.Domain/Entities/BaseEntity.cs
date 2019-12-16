using Simple_Shop.Domain.Events;
using System.Collections.Generic;

namespace Simple_Shop.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public ICollection<BaseDomainEvent> Events { get; set; }
    }
}
