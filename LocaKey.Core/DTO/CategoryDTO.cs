using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        [Display(Name="الاسم بالعربية ")]
        public string nameAr { get; set; }
        [Display(Name = "الاسم بالانجليزية ")]
        public string nameEn { get; set; }
        [Display(Name = "الاسم بلفرنسية ")]
        public string nameFr { get; set; }
    }
}
