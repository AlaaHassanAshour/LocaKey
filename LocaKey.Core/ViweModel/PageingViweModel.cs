using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.ViweModel
{
    public class PageingViweModel
    {
        public int CurrantPage { get; set; }
        public int NumberOfPages { get; set; }
        public Object Data { get; set; }
    }
}
