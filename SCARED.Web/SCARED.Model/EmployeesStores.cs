using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scared.Model
{
   public class EmployeesStores
    {

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }


    }
}
