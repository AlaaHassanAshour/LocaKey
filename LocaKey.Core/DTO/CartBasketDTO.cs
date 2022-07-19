using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Core.DTO
{
    public class CartBasketDTO
    {
        public int Id { get; set; }
        [Display(Name = "الكمية الكلية ")]
        public int total { get; set; }
        [Display(Name = "الكمية المباعة ")]
    
        public int quantitySold { get; set; }
        [Display(Name = "الكمية المتاحة ")]
        public int availableQuantity { get; set; }
        [Display(Name = "المنتج ")]
        public int ProductId { get; set; }
        [Display(Name = "المشتري")]
        public int UserId { get; set; }

    }
}
