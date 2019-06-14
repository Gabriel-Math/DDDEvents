using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDEvents.Shared.Entities;

namespace DDDEvents.Domain.Events.Entities
{
    public class Budget : Entity
    {
        public Budget(decimal initialBudget, decimal adults, decimal children)
        {
            InitialBudget = initialBudget;
            AdultsAmount = adults;
            ChildrenAmount = children;
        }

        public decimal InitialBudget { get; private set; }
        public decimal AdultsAmount { get; private set; }
        public decimal ChildrenAmount { get; private set; }
        public bool Active { get; set; }
    }
}
