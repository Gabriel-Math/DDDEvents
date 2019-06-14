using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDEvents.Infra.Contexts;

namespace DDDEvents.Infra.Transactions
{
    public class Uow : IUow
    {
        private readonly DDDEvents_EventsDataContext _context;

        public Uow(DDDEvents_EventsDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            //Não necessita implementar, pois o próprio EF cuida da requisição e deixa morrer caso não
            //seja dado o commit.
        }
    }
}
