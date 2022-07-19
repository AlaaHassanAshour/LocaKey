using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.DTO
{
    public class AboutDTO
    {
        public int? Id { get; set; }
        [Required]
        [Display(Name = "الاسم ")]
        public string name { get; set; }
        [Required]
        [Display(Name = "الصورة ")]
        public string logo { get; set; }
        [Required]
        [Display(Name = "العنوان ")]

        public string title { get; set; }
        [Required]
        [Display(Name = "التفاصيل ")]

        public string description { get; set; }
        [Display(Name = "الهاتف")]

        public string phone { get; set; }
        [Display(Name = "الايميل")]

        public string email { get; set; }
    }
}
