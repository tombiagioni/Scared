using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCARED.Model
{
    class Stores_Districts
    {

        public int StoreId { get; set; }
        public Store Store { get; set; }

        public int DistrictId { get; set; }
        public District District { get; set; }


    }
}
