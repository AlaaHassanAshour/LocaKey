using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.Coupons
{
    public class CouponsService : ICouponsService
    {
        private ApplicationDbContext _context;

        public CouponsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public CouponsVM Get(int id)
        {

            var coupon = _context.Coupons.Select(x => new CouponsVM()
            {
                Id = x.Id,
                name = x.name,
                code = x.code,
                countUse = x.countUse,
                De_activation = x.De_activation,
                discountType= (CouponsVM.DiscountType)x.discountType
                
            }).FirstOrDefault(x => x.Id == id);
            return coupon;
        }
        public List<CouponsVM> GetAll()
        {
            var couponsVm = _context.Coupons.Where(x => x.IsDelete.Equals(false)).OrderByDescending(x => x.Id).Select(x => new CouponsVM()
            {
                Id = x.Id,
                name = x.name,
                code = x.code,
                countUse = x.countUse,
                De_activation = x.De_activation,
                discountType = (CouponsVM.DiscountType)x.discountType

            }).ToList();

            return couponsVm;
        }
        public void Create(CouponsDTO dto)
        {

            var coupons = new LocaKey.Data.Entity.Coupons();
            coupons.name = dto.name;
            coupons.code = dto.code;
            coupons.De_activation = dto.De_activation;
            coupons.countUse = dto.countUse;
            coupons.discountType = (Data.Entity.Coupons.DiscountType)dto.discountType;

            _context.Coupons.Add(coupons);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var Coupons = _context.Coupons.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            Coupons.IsDelete = true;
            _context.Coupons.Update(Coupons);
            _context.SaveChanges();
        }



        public void Update(CouponsDTO dto)
        {
            var coupons = _context.Coupons.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);
            coupons.name = dto.name;
            coupons.code = dto.code;
            coupons.De_activation = dto.De_activation;
            coupons.countUse = dto.countUse;
            coupons.discountType= (Data.Entity.Coupons.DiscountType)dto.discountType;
            _context.Coupons.Update(coupons);
            _context.SaveChanges();
        }
    }
}
