using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDEvents.Shared.Entities;
using DDDEvents.Domain.Events.ValueObjects;

namespace DDDEvents.Domain.Events.Entities
{
    public class Event : Entity
    {
        public Event(string eventName, EventDate eventDate, Address address)
        {
            EventName = eventName;
            EventDate = eventDate;
            Address = address;
        }

        public String EventName { get; private set; }
        public EventDate EventDate { get; private set; }
        public Address Address { get; private set; }
        public bool Active { get; set; }
        public Budget Budget { get; set; }
    }
}
