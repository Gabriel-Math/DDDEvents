using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DDDEvents.Domain.Events.Entities;

namespace DDDEvents.Domain.Events.Repositories
{
    public interface IUserRepository
    {
        User GetById(Guid id);
        void Save(User user);
        IEnumerable<User> GetUsers();
    }
}
