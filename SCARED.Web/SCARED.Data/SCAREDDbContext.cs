using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using Scared.Model;


namespace Scared.Data
{
    public class ScaredDbContext : DbContext
    {

        static ScaredDbContext()
        {
           // Database.SetInitializer(new SCAREDDatabaseInitializer());

        }

        public ScaredDbContext() : base(nameOrConnectionString: "SCAREDConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            //Add configuration connections here
            modelBuilder.Configurations.Add(new EmployeesStoresConfiguration());
            modelBuilder.Configurations.Add(new StoresDistrictsConfiguration());
            //modelBuilder.Configurations.Add(new TransactionsConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<EmployeesStores> EmployeesStores { get; set; }
        public DbSet<StoresDistricts> StoresDistricts { get; set; }

        //Lookups
        public DbSet<Store> Stores { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Shift> Shifts { get; set; }




    }
}
