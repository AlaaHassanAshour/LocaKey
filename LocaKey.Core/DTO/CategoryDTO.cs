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
        [Display(Name="الاسم ")]
        public string name { get; set; }
    }
}
