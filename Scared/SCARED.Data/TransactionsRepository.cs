using Scared.Data.Contracts;
using Scared.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scared.Data
{
    public class TransactionsRepository : EFRepository<Transactions>, ITransactionsRepository
    {
        public TransactionsRepository(DbContext context) : base(context) { }

        public IQueryable<TransactionsBrief> GetTransactionsBriefs()
        {
            return DbSet.Select(s => new TransactionsBrief
            {
                Id = s.Id,
                EmployeeId = s.EmployeeId,
                StoreId = s.StoreId,
                ManagerId = s.ManagerId,
                StartTime = s.StartTime,
                EndTime = s.EndTime,
                TotalTime = s.TotalTime
            });

        }
    }
}
