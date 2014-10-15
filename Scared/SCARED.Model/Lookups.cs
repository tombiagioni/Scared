using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scared.Model
{
    class Lookups
    {
        public IList<Store> Stores { get; set; }
        public IList<Shift> Shifts { get; set; }
        public IList<District> Districts { get; set; }
    }
}
