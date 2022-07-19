using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class Currency:BaseEntity
    {
        public string currency { get; set; }
        public int languageId { get; set; }
        public language language { get; set; }
    }
}
