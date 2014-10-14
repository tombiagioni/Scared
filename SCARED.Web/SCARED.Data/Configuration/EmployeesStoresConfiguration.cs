using SCARED.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCARED.Data
{
    public class EmployeesStoresConfiguration : EntityTypeConfiguration<EmployeesStores>
    {

        public EmployeesStoresConfiguration()
        {

            //Creating composite Key: StoreId and Employee Id
            HasKey(a => new { a.StoreId, a.EmployeeId });


            //EmployeesStores has one Store, Stores have many Employee Records
            HasRequired(es => es.Store)
                .WithMany(s => s.Employees)
                .HasForeignKey(es => es.StoreId)
                .WillCascadeOnDelete(false);

            //EmployeesStores has one employee, Employees have many Store Records
            HasRequired(es => es.Employee)
                .WithMany(e => e.Stores)
                .HasForeignKey(es => es.EmployeeId)
                .WillCascadeOnDelete(false);

        }
    }
}
