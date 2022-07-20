using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.DTO
{
    public class CartCookiesDTO
    {
        public string Id { get; set; }
        [Display(Name = "الكمية الكلية ")]
        public int total { get; set; }
        [Display(Name = "المنتج ")]
        public int ProductId { get; set; }
        [Display(Name = "المشتري")]
        public int UserId { get; set; }

    }
}
