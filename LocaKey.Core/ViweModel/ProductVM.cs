using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.ViweModel
{
    public class ProductVM
    {
        public int Id { get; set; }
        [Display(Name = "الاسم بالعربية")]
        public string name_ar { get; set; }
        [Display(Name = "الاسم بالانجبيزية")]
        public string name_en { get; set; }
        [Display(Name = "الاسم بالفرنسية")]
        public string name_fr { get; set; }
        [Display(Name = "التفاصيل بالعربية")]
        public string description_ar { get; set; }
        [Display(Name = "التفاصيل بالانجليزية")]
        public string description_en { get; set; }
        [Display(Name = "التفاصيل بالفرنسية")]
        public string description_fr { get; set; }
        [Display(Name = "السعر بالعربية")]
        public float price_ar { get; set; }
        [Display(Name = "السعر بالانجليزية")]
        public float price_en { get; set; }
        [Display(Name = "السعر بالفرنسية")]
        public float price_fr { get; set; }
        [Display(Name = "الكمية")]
        public int count { get; set; }
        [Display(Name = "الاسم الصورة")]
        public string imege { get; set; }
        public enum Type { normal = 0, offer = 1, popular = 2 }
        public Type type { get; set; }
        [Display(Name = "المنتج")]
        public CategoryVM Category { get; set; }


    }
}
