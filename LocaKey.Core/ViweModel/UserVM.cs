using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.ViweModel
{
    public class UserVM
    {
        public int Id{ get; set; }
        [Display(Name = "الاسم كامل")]
        public string fullName { get; set; }

        [Display(Name = "الايميل")]

        public string Email { get; set; }
        [Display(Name = "رقم الهاتف")]

        public string Phone { get; set; }

    }
}
