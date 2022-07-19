using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
     public class SiteVisitsReport:BaseEntity
    {
        public int site_visit { get; set; }
        public string MacAddress { get; set; }
        public string IpAddress { get; set; }
    }

}
