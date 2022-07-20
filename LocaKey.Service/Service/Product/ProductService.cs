using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.Product
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public ProductVM Get(int id)
        {

            var product = _context.Products.Select(x => new ProductVM()
            {
                Category = new CategoryVM()
                {
                    nameAr = x.Category.nameAr,
                    nameEn= x.Category.nameEn,
                    nameFr= x.Category.nameFr
                },
                description_ar = x.description_ar,
                description_en = x.description_en,
                description_fr = x.description_fr,
                Id = x.Id,
                imege = x.imege,
                name_ar = x.name_ar,
                name_en = x.name_en,
                name_fr = x.name_fr,
                price_ar = x.price_ar,
                price_en = x.price_en,
                price_fr = x.price_fr,

            }
            ).FirstOrDefault(x => x.Id == id);
            return product;
        }
        public List<ProductVM> GetAll(int? categoryId , int? count)
        {
            if (count==null)
            {
                count = 1000;
            }
            var products = _context.Products.Include(x => x.Category).Where(x => x.IsDelete.Equals(false) && (x.CategoryId ==categoryId || categoryId==null)
                && (x.count<=count )).OrderByDescending(x => x.Id).Select(x => new ProductVM()
            {
                Category = new CategoryVM()
                {
                    nameAr = x.Category.nameAr,
                    nameEn = x.Category.nameEn,
                    nameFr = x.Category.nameFr
                },
                description_ar = x.description_ar,
                description_en = x.description_en,
                description_fr = x.description_fr,
                Id = x.Id,
                imege = x.imege,
                name_ar = x.name_ar,
                name_en = x.name_en,
                name_fr = x.name_fr,
                price_ar = x.price_ar,
                price_en = x.price_en,
                price_fr = x.price_fr,
                count = x.count,
            }
            ).ToList();
            return products;
        }
        public void Create(ProductDTO dto)
        {
            var prduct = new LocaKey.Data.Entity.Product()
            {
                CategoryId = dto.CategoryId,
                description_ar = dto.description_ar,
                description_en = dto.description_en,
                description_fr = dto.description_fr,
                price_ar = dto.price_ar,
                price_en = dto.price_en,
                price_fr = dto.price_fr,
                name_ar = dto.name_ar,
                name_en = dto.name_en,
                name_fr = dto.name_fr,
                imege = dto.imege,
                count = dto.count,
            };
            _context.Add(prduct);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var prduct = _context.Products.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            prduct.IsDelete = true;
            _context.Products.Update(prduct);
            _context.SaveChanges();
        }
        public void Update(ProductDTO dto)
        {
            var prduct = _context.Products.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);
            prduct.price_fr = dto.price_fr;
            prduct.price_ar = dto.price_ar;
            prduct.price_en = dto.price_en;
            prduct.name_ar = dto.name_ar;
            prduct.name_fr = dto.name_fr;
            prduct.name_en = dto.name_en;
            prduct.description_ar = dto.description_ar;
            prduct.description_fr = dto.description_fr;
            prduct.description_en = dto.description_en;
            prduct.imege = dto.imege;

            _context.Products.Update(prduct);
            _context.SaveChanges();
        }
    }
}
