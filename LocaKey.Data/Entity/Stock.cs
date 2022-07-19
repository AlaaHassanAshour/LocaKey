using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class Stock:BaseEntity
    {
        public int quantity_sold { get; set; }
        public int available_quantity{ get; set; }
        public int total { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
  
    }
}