using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Data.Entity
{
    public class Client:BaseEntity
    {
        public string country { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
