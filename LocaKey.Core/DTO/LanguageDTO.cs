using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.DTO
{
    public class LanguageDTO
    {
        public int Id{ get; set; }
        [Display(Name = "اللغة")]
        public string Language { get; set; }

    }
}
