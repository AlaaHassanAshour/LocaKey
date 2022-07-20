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
        [Display(Name = "اللغة")]
        public string Language { get; set; }
      
    }
}
