using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class productReport:BaseEntity
    {
        public int count_product_buying { get; set; }
        public int base_price { get; set; }
        public int price_withe_buying { get; set; }
        public int total { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
