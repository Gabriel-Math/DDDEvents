using System;
using DDDEvents.Shared.ValueObject;
using Flunt.Validations;

namespace DDDEvents.Domain.Events.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string mailAddress)
        {
            MailAddress = mailAddress;
        }

        public string MailAddress { get; set; }
    }
}
