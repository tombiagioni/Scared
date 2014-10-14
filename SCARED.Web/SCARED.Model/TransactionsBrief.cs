using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCARED.Model
{
    class TransactionsBrief
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int StoreId { get; set; }
        public int ManagerId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal TotalTime { get; set; } //calcuated field popluated after clock out action

    }
}
