using System;
using System.Collections.Generic;
using DDDEvents.Domain.Events.Entities;

namespace DDDEvents.Domain.Events.Repositories
{
    public interface IEventRepository
    {
        Event Get(Guid id);
        IList<Event> GetEvents(List<Guid> ids);
    }
}
