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
        [Display(Name = "الاسم ")]

        public string name { get; set; }
        [Display(Name = "التفاصيل")]

        public string description { get; set; }

        public string MacAddress { get; set; }
        public string IpAddress { get; set; }
    }
}
