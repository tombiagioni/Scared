using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCARED.Model
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EmployeesStores> Employees { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}
