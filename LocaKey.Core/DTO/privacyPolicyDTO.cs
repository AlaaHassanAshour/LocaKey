﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.DTO
{
    public class privacyPolicyDTO
    {
        public int Id{ get; set; }
        [Display(Name = "العربية")]
        public string name { get; set; }
        [Display(Name = "التفاصل")]
        public string description { get; set; }
    }
}
