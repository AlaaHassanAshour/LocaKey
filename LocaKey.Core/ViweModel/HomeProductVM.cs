using LocaKey.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.ViweModel
{
    public class HomeProductVM
    {
        public List<Category> category{ get; set; }
        public List<Product> products{ get; set; }
        public Product product { get; set; }

    }
}
