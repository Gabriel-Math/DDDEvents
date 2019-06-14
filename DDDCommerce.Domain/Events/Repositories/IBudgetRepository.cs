using System;
using System.Collections.Generic;
using DDDEvents.Domain.Events.Entities;

namespace DDDEvents.Domain.Events.Repositories
{
    public interface IBudgetRepository
    {
        Budget Get(Guid id);
        IList<Budget> GetBudgets(List<Guid> ids);
    }
}
