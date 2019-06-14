using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDEvents.Domain.Events.Entities;

namespace DDDEvents.Infra.Mappings
{
    public class UserMap: EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("User");
            HasKey(x => x.Id);
            Property(x => x.Document).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Email.MailAddress).HasMaxLength(60);
            Property(x => x.Name.FirstName).HasMaxLength(50);
            Property(x => x.Name.LastName).HasMaxLength(50);

        }
    }
}
