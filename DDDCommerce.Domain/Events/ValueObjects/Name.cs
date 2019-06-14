using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDEvents.Shared.ValueObject;
using Flunt.Validations;

namespace DDDEvents.Domain.Events.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
