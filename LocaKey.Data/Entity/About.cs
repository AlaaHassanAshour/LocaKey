using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class About : BaseEntity
    {
        [Required]
        public string name { get; set; }
        [Required]

        public string logo { get; set; }
        [Required]

        public string title { get; set; }
        [Required]
        public string description { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }
}
