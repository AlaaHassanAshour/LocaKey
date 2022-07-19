using LocaKey.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.ViweModel
{
    public class StockVM
    {
        public int Id{ get; set; }
        public int quantity_sold { get; set; }
        public int available_quantity { get; set; }
        public int total { get; set; }
        public Product Product { get; set; }
    }
}
