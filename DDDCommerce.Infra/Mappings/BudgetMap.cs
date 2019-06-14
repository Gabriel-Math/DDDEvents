using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDEvents.Domain.Events.Entities;

namespace DDDEvents.Infra.Mappings
{
    public class BudgetMap: EntityTypeConfiguration<Budget>
    {
        public BudgetMap()
        {
            ToTable("Budget");
            HasKey(x => x.Id);
            Property(x => x.Description).IsRequired().HasMaxLength(180);
            Property(x => x.Image);
            Property(x => x.Price).HasColumnType("money");
            Property(x => x.QuantityOnHand);
            Property(x => x.Title).IsRequired().HasMaxLength(80);
            
        }
    }
}
