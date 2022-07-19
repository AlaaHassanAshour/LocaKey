using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class SalesReport:BaseEntity
    {
        public int productBuying{ get; set; }
        public int count{ get; set; }
        public int basePrice { get; set; }
        public int priceWitheBuying { get; set; }
        public int total{ get; set; }
    }
}
