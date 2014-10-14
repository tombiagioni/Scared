using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCARED.Model
{
    class Transactions : TransactionsBrief
    {

        public Transactions()
        {

        }

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedBy { get; set; } //set to EmployeeId of Modifier
        public string ModifiedNote { get; set; }

        public virtual Employee Manager { get; set; }
        public virtual Store Store { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
