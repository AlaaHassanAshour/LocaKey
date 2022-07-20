using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.Language
{
    public class LanguageService: ILanguageService
    {
        private ApplicationDbContext _context;

        public LanguageService(ApplicationDbContext context)
        {
            _context = context;
        }
        public LanguageVM Get(int id)
        {

            var language = _context.language.Select(x => new LanguageVM()
            {
                Id = x.Id,
               Language = x.Language,
            }).FirstOrDefault(x => x.Id == id);
            return language;
        }
        public List<LanguageVM> GetAll()
        {
            var languages = _context.language.Where(x => x.IsDelete.Equals(false)).OrderByDescending(x => x.Id).Select(x => new LanguageVM()
            {
                Id = x.Id,
                Language = x.Language,
            }).ToList();

            return languages;
        }
        public void Create(LanguageDTO dto)
        {

            var language = new LocaKey.Data.Entity.language() {

                Id = dto.Id,
             Language=dto.Language,
            };
           

            _context.language.Add(language);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var language = _context.language.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            language.IsDelete = true;
            _context.language.Update(language);
            _context.SaveChanges();
        }



        public void Update(LanguageDTO dto)
        {
            var language = _context.language.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);
            language.Language= dto.Language;
            _context.language.Update(language);
            _context.SaveChanges();
        }
    }
}
