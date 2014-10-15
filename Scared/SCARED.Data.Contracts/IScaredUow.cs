using Scared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scared.Data.Contracts
{
    public interface IScaredUow

    {
        void Commit();

        //Add repositories Here.
        ITransactionsRepository Transactions { get; }
        IEmployeesRepository Employees { get; }
        IEmployeesStoresRepository EmployeesStores { get; }
        IStoresDistrictsRepository StoresDistricts { get; }
        IRepository<Store> Stores { get; }
        IRepository<Shift> Shifts { get; }
        IRepository<District> Districts { get; }


    }
}
