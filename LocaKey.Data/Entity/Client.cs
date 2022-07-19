using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class Client : User
    {
        public string country { get; set; }
        public string registration_date { get; set; }
        public int languageId { get; set; }
        public language language { get; set; }
    }
}
