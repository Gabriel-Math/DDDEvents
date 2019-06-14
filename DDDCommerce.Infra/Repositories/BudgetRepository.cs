using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDEvents.Domain.Events.Entities;
using DDDEvents.Domain.Events.Repositories;
using DDDEvents.Infra.Contexts;

namespace DDDEvents.Infra.Repositories
{
    public class BudgetRepository : IBudgetRepository
    {
        private readonly DDDEvents_EventsDataContext _context;

        public BudgetRepository(DDDEvents_EventsDataContext context)
        {
            _context = context;
        }

        public Budget Get(Guid id)
        {
            return _context.Budgets.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IList<Budget> GetBudgets(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }
}
