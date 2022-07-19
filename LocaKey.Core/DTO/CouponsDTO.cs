using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.DTO
{
    public class CouponsDTO
    {
        public int Id{ get; set; }
        [Required]
        [Display(Name = "الاسم")]
        public string name { get; set; }
        [Required]
        [Display(Name = "الكود")]

        public string code { get; set; }

        public enum DiscountType { Percentage = 0, value = 1 }
        [Display(Name = "نوع الخصم")]

        public DiscountType discountType { get; set; }
        [Display(Name = "الكمية المستخدمة")]

        public int countUse { get; set; }
        [Display(Name = "حالة النشاط")]


        public bool De_activation { get; set; }
       
    }
}
