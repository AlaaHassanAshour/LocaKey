using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.privacyPolicy
{
    public class privacyPolicyService : IprivacyPolicyService
    {
        private ApplicationDbContext _context;

        public privacyPolicyService(ApplicationDbContext context)
        {
            _context = context;
        }
        public privacyPolicyVM Get(int id)
        {

            var privacyPolicy = _context.privacyPolicy.Select(x => new privacyPolicyVM()
            {
                Id = x.Id,
                nameAr = x.nameAr,
                nameEn = x.nameEn,
                nameFr = x.nameFr,
                descriptionAr = x.descriptionAr,
                descriptionEn = x.descriptionEn,
                descriptionFr = x.descriptionFr,
            }).FirstOrDefault(x => x.Id == id);
            return privacyPolicy;
        }
        public List<privacyPolicyVM> GetAll()
        {
            var categoriesVm = _context.privacyPolicy.Where(x => x.IsDelete.Equals(false)).OrderByDescending(x => x.Id).Select(x => new privacyPolicyVM()
            {
                Id = x.Id,
                nameAr = x.nameAr,
                nameEn = x.nameEn,
                nameFr = x.nameFr,
                descriptionAr = x.descriptionAr,
                descriptionEn = x.descriptionEn,
                descriptionFr = x.descriptionFr,
            }).ToList();

            return categoriesVm;
        }
        public void Create(privacyPolicyDTO dto)
        {

            var privacyPolicy = new LocaKey.Data.Entity.privacyPolicy();

            privacyPolicy.nameEn = dto.nameEn;
            privacyPolicy.nameFr = dto.nameFr;
            privacyPolicy.nameAr = dto.nameAr;
            privacyPolicy.descriptionAr = dto.descriptionAr;
            privacyPolicy.descriptionEn = dto.descriptionEn;
            privacyPolicy.descriptionFr = dto.descriptionFr;
            _context.privacyPolicy.Add(privacyPolicy);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _context.privacyPolicy.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            category.IsDelete = true;
            _context.privacyPolicy.Update(category);
            _context.SaveChanges();
        }



        public void Update(privacyPolicyDTO dto)
        {
            var privacyPolicy = _context.privacyPolicy.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);
            privacyPolicy.nameEn = dto.nameEn;
            privacyPolicy.nameAr= dto.nameAr;
            privacyPolicy.nameFr = dto.nameFr;
            privacyPolicy.descriptionAr = dto.descriptionAr;
            privacyPolicy.descriptionEn = dto.descriptionEn;
            privacyPolicy.descriptionFr = dto.descriptionFr;
            _context.privacyPolicy.Update(privacyPolicy);
            _context.SaveChanges();
        }
    }
}
