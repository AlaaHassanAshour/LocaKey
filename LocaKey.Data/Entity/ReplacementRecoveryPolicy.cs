using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class ReplacementRecoveryPolicy : BaseEntity
    {
        public string name { get; set; }
        public string description { get; set; }
        public string MacAddress { get; set; }
        public string IpAddress { get; set; }
    }
}