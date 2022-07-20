using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.DTO
{
    public class ReplacementRecoveryPolicyDTO
    {
        public int Id { get; set; }
        [Display(Name = " الاسم بالعربية ")]

        public string nameAr { get; set; }
        [Display(Name = "الاسم بالانجليزية")]
        public string nameEn { get; set; }
        [Display(Name = "الاسم بالفرنسية")]

        public string nameFr { get; set; }
        [Display(Name = "  الوصف بالعربية")]

        public string descriptionAr { get; set; }
        [Display(Name = "  الوصف بالانجليزية")]

        public string descriptionEn { get; set; }
        [Display(Name = "  الوصف بالفرنسية")]

        public string descriptionFr { get; set; }

        public string MacAddress { get; set; }
        public string IpAddress { get; set; }
    }
}
