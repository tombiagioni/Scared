using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SCARED.Model
{
    public class Employee
    {

        public Employee()
        {
            Gender = "";//Make no assumptions

        }

        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Gender { get; set; }

        public DateTime HireDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public decimal PayRate { get; set; }
        //employmentType
        public int HomeStoreId { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsClockedIn { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Transactions> TransactionsList { get; set; }
        public virtual ICollection<EmployeesStores> Stores { get; set; }



    }
}
