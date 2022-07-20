using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class Category: BaseEntity
    {
        [Required]

        public string nameAr { get; set; }
        public string nameEn { get; set; }
        public string nameFr { get; set; }

    }
}
