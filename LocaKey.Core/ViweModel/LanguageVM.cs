using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.ViweModel
{
    public class LanguageVM
    {
        public int Id { get; set; }
        [Display(Name = "العربية")]
        public string Arabic { get; set; }
        [Display(Name = "الانجليزية")]
        public string English { get; set; }
        [Display(Name = "الفرنسية")]
        public string France { get; set; }
    }
}
