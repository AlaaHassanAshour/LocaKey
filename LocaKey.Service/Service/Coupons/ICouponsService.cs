using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.Coupons
{
    public interface ICouponsService
    {
        CouponsVM Get(int id);
        List<CouponsVM> GetAll();

        void Delete(int id);

        void Create(CouponsDTO dto);

        void Update(CouponsDTO entity);

    }
}
