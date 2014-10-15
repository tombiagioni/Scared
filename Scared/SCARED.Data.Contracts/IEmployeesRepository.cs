using Scared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scared.Data.Contracts
{
    public interface IEmployeesRepository : IRepository<Employee>
    {
        IQueryable<Employee> GetManagers();
    }
}
