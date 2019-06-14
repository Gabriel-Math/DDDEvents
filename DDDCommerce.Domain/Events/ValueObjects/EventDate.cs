using DDDEvents.Shared.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDEvents.Domain.Events.ValueObjects
{
    public class EventDate : ValueObject
    {
        public EventDate(string beginDate, string endDate)
        {
            BeginDate = beginDate;
            EndDate = endDate;
        }

        public string BeginDate { get; set; }
        public string EndDate { get; set; }
    }
}
