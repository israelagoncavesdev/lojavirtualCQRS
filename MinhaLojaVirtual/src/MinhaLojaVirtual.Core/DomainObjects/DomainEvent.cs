using System;
using MinhaLojaVirtual.Core.Messages;

namespace MinhaLojaVirtual.Core.DomainObjects
{
    public class DomainEvent : Event
    {
        public DomainEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}