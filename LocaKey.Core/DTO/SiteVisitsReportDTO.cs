using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.DTO
{
    public class SiteVisitsReportDTO
    {
        public int Id{ get; set; }
        [Display(Name = "زيارات الموقع")]
        public int site_visit { get; set; }
        public string MacAddress { get; set; }
        public string IpAddress { get; set; }
    }
}
