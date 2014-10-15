using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scared.Model;


namespace Scared.Data.Contracts
{
    public interface IEmployeesStoresRepository : IRepository<EmployeesStores>
    {

        IQueryable<EmployeesStores> GetByEmployeeId(int id);
        IQueryable<EmployeesStores> GetByStoreId(int id);
        EmployeesStores GetByIds(int employeeId, int storeId);
        void Delete(int employeeId, int storeId);
    }
}
