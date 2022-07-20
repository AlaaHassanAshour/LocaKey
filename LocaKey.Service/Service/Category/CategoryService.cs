using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.Category
{
    public class CategoryService : ICategoryService
    {
        private ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public CategoryVM Get(int id)
        {

            var Category = _context.Categorys.Select(x => new CategoryVM()
            {
                Id = x.Id,
                nameAr = x.nameAr,
                nameEn= x.nameEn,
                nameFr= x.nameFr,
            }).FirstOrDefault(x => x.Id == id);
            return Category;
        }
        public List<CategoryVM> GetAll()
        {
            var categoriesVm = _context.Categorys.Where(x => x.IsDelete.Equals(false)).OrderByDescending(x => x.Id).Select(x => new CategoryVM()
            {
                Id = x.Id,
                nameAr = x.nameAr,
                nameEn = x.nameEn,
                nameFr = x.nameFr,
            }).ToList();

            return categoriesVm;
        }
        public void Create(CategoryDTO dto)
        {

            var category = new LocaKey.Data.Entity.Category();
            category.nameAr = dto.nameAr;
            category.nameEn = dto.nameEn;
            category.nameFr= dto.nameFr;

            _context.Categorys.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _context.Categorys.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            category.IsDelete = true;
            _context.Categorys.Update(category);
            _context.SaveChanges();
        }



        public void Update(CategoryDTO dto)
        {
            var category = _context.Categorys.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);
            category.nameAr = dto.nameAr;
            category.nameEn = dto.nameEn;
            category.nameFr = dto.nameFr;
            _context.Categorys.Update(category);
            _context.SaveChanges();
        }
    }
}
