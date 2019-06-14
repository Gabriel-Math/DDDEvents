using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDEvents.Shared.Entities;
using DDDEvents.Domain.Events.ValueObjects;

namespace DDDEvents.Domain.Events.Entities
{
    public class User : Entity
    {

        public User(Name name, string document, Email email, string v)
        {
            Name = name;
            Document = document;
            Email = email;
        }

        public Name Name { get; private set; }
        public String Document { get; private set; }
        public Email Email { get; private set; }
        public List<Event> Events { get; set; }
        public List<Budget> Budgets { get; set; }
    }
}
