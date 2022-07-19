using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.DTO
{
    public class UserDTO
    {
        [Required]
        [Display(Name = "الاسم كامل")]

        public string fullName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "الايميل")]

        public string Email { get; set; }
        [Required]
        [Phone]
        [Display(Name = "رقم الهاتف")]

        public string Phone { get; set; }
    }
}
