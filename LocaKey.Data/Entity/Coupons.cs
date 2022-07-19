using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class Coupons : BaseEntity
    {
        [Required]

        public string name { get; set; }
        [Required]

        public string code { get; set; }
        public enum DiscountType { Percentage = 0, value = 1 }
        public DiscountType discountType { get; set; }

        public int countUse { get; set; }
        public bool De_activation { get; set; }
    }
}
