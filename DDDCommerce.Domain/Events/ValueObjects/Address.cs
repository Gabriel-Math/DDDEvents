using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Notifications;
using DDDEvents.Shared.ValueObject;
using Flunt.Validations;

namespace DDDEvents.Domain.Events.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string cep, string logra, string number, string city, string state)
        {
            Cep = cep;
            Logra = logra;
            Number = number;
            City = city;
            State = state;
        }

        public string Cep { get; set; }
        public string Logra { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
