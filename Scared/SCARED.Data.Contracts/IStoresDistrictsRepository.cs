using Scared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scared.Data.Contracts
{
    public interface IStoresDistrictsRepository : IRepository<StoresDistricts>
    {
        IQueryable<StoresDistricts> GetByStoreId(int id);
        IQueryable<StoresDistricts> GetByDistrictId(int id);
        StoresDistricts GetByIds(int storeId, int DistrictId);
        void Delete(int storeId, int districtId);

    }
}
