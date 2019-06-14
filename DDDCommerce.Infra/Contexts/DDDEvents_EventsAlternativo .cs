using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDEvents.Domain.Events.Entities;
using DDDEvents.Infra.Mappings;

namespace DDDEvents.Infra.Contexts
{
    public class DDDEvents_EventsDataContext : DbContext
    {

        public DDDEvents_EventsDataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BancoDDD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            //Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Budget> Budgets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new BudgetMap());
        }
    }
}
