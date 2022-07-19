using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class Product:BaseEntity
    {
        [Required]
        public string name_ar{ get; set; }
        [Required]
        public string name_en{ get; set; }
        [Required]
        public string name_fr{ get; set; }
        [Required]
        public string description_ar{ get; set; }
        [Required]
        public string description_en{ get; set; }
        [Required]
        public string description_fr{ get; set; }
        [Required]
        public float price_ar { get; set; }
        [Required]
        public float price_en { get; set; }
        [Required]
        public float price_fr { get; set; }
        [Required]
        public string imege { get; set; }
        public int  count{ get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int? CouponsId { get; set; }
        public Coupons Coupons { get; set; }

    }
}
