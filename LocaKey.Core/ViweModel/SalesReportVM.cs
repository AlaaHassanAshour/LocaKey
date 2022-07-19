using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.ViweModel
{
    public class SalesReportVM
    {
        public int Id { get; set; }
        [Display(Name = "المنتاجات التي تم شرئها")]

        public int productBuying { get; set; }
        [Display(Name = "الكمية")]

        public int count { get; set; }
        [Display(Name = "السعر الاساسي")]

        public int basePrice { get; set; }
        [Display(Name = "السعر عند الشراء")]

        public int priceWitheBuying { get; set; }
        [Display(Name = "اجمالي")]

        public int total { get; set; }
    }
}
