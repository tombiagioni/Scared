using Scared.Model;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;


namespace Scared.Data
{
    public class StoresDistrictsConfiguration : EntityTypeConfiguration<StoresDistricts>
    {

        
        public StoresDistrictsConfiguration()
        {
            //Store has 1 Discrict, District can have many stores
            HasRequired(s => s.District)
                .WithMany(d => d.Stores)
                .HasForeignKey(s => s.DistrictId);
        }
    }
}
