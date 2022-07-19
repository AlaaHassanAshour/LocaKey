using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class CartCookies : BaseEntity
    {
        public int total { get; set; }
        public int quantitySold { get; set; }
        public int availableQuantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int  UserId{ get; set; }
        public User User { get; set; }
    }
}