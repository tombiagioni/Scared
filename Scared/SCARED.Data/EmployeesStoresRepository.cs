using Scared.Model;
using Scared.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Scared.Data
{
    public class EmployeesStoresRepository : EFRepository<EmployeesStores>, IEmployeesStoresRepository
    {

        public EmployeesStoresRepository(DbContext context) : base(context) { }


        public override EmployeesStores GetById(int id)
        {
            throw new InvalidOperationException("Cannot return a single EmployeesStores object by a single value.");
            
        }

        public EmployeesStores GetByIds(int employeeId, int storeId)
        {

            return DbSet.FirstOrDefault(e => e.EmployeeId == employeeId && e.StoreId == storeId);
        }

        public IQueryable<EmployeesStores> GetByEmployeeId(int id)
        {
            return DbSet.Where(e => e.EmployeeId == id);

        }

        public IQueryable<EmployeesStores> GetByStoreId(int id)
        {
            return DbSet.Where(s => s.StoreId == id);
        }

        public override void Delete(int id)
        {
            throw new InvalidOperationException("Cannot delete EmployeesStores Object by a single id value");

        }

        public void Delete(int employeeId, int storeId)
        {
            // EF needs an EmployeesStores entity to delete (can't delete with the id)
            // Don't need the REAL entity though. A placeholder with the ids in it will do.
            var employeesStores = new EmployeesStores { EmployeeId = employeeId, StoreId = storeId };
                Delete(employeesStores);
        }

    }
}
