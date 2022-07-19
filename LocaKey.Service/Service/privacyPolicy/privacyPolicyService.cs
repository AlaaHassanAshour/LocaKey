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
    public class privacyPolicyService: IprivacyPolicyService
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
                name = x.name,
                description=x.description
            }).FirstOrDefault(x => x.Id == id);
            return privacyPolicy;
        }
        public List<privacyPolicyVM> GetAll()
        {
            var categoriesVm = _context.privacyPolicy.Where(x => x.IsDelete.Equals(false)).OrderByDescending(x => x.Id).Select(x => new privacyPolicyVM()
            {
                Id = x.Id,
                name = x.name,
                description = x.description
            }).ToList();

            return categoriesVm;
        }
        public void Create(privacyPolicyDTO dto)
        {

            var privacyPolicy = new LocaKey.Data.Entity.privacyPolicy();
            privacyPolicy.name = dto.name;
            privacyPolicy.description= dto.description;

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
            var category = _context.Categorys.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);
            category.name = dto.name;
            _context.Categorys.Update(category);
            _context.SaveChanges();
        }
    }
}
