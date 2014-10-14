using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using SCARED.Model;


namespace SCARED.Data
{
    public class SCAREDDbContext : DbContext
    {

        static SCAREDDbContext()
        {
           // Database.SetInitializer(new SCAREDDatabaseInitializer());

        }

        public SCAREDDbContext() : base(nameOrConnectionString: "SCAREDConnectionString") { }

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
