using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.CartBasket
{
    public interface ICartCookiesService
    {
        CartCookiesVM Get(int id);
        List<CartCookiesVM> GetAll();
        void Delete(int id);
        void Create(CartCookiesDTO dto);
        void Update(CartCookiesDTO entity);

    }
}
