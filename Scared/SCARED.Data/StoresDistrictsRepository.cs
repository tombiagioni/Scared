using Scared.Data.Contracts;
using Scared.Model;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scared.Data
{
    public class StoresDistrictsRepository : EFRepository<StoresDistricts>, IStoresDistrictsRepository
    {
        public StoresDistrictsRepository(DbContext context) : base(context) { }

        public override StoresDistricts GetById(int id)
        {
            throw new InvalidOperationException("Cannot return a single StoresDistrict object by a single value");
        }
        
        public StoresDistricts GetByIds(int storeId, int districtId)
        {
            return DbSet.FirstOrDefault(e => e.StoreId == storeId && e.DistrictId == districtId);

        }

        public IQueryable<StoresDistricts> GetByStoreId(int id)
        {
            return DbSet.Where(s => s.StoreId == id);

        }

        public IQueryable<StoresDistricts> GetByDistrictId(int id)
        {
            return DbSet.Where(d => d.DistrictId == id);
        }


        public override void Delete(int id)
        {
            throw new InvalidOperationException("Cannot delete StoresDistricts Object by a single id value");
        }

        public void Delete(int storeId,int districtId)
        {
            // EF needs an StoresDistricts entity to delete (can't delete with the id)
            // Don't need the REAL entity though. A placeholder with the ids in it will do.
            var storesDistricts = new StoresDistricts { StoreId = storeId, DistrictId = districtId };
            Delete(storesDistricts);

        }
    }
}
