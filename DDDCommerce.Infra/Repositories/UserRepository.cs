using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDEvents.Domain.Events.Entities;
using DDDEvents.Domain.Events.Repositories;
using DDDEvents.Infra.Contexts;

namespace DDDEvents.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DDDEvents_EventsDataContext _context;

        public UserRepository(DDDEvents_EventsDataContext context)
        {
            _context = context;
        }

        public User GetById(Guid id)
        {
            return _context.Users.AsNoTracking().FirstOrDefault(x => x.Id == id);
            //AsNoTracking não faz Cache dos dados da entidade no EF, não fica fazendo histórico 
            //das mudanças da entidade, somente faz a leitura e pronto, performance.
        }

        public void Save(User user)
        {
            if (user.Valid)
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public Task<List<User>> GetUsers()
        {

            return _context.Users.ToListAsync();
        }
    }
}
