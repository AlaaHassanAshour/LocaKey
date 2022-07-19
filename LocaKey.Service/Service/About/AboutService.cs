using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.About
{
    public class AboutService: IAboutService
    {
        private ApplicationDbContext _context;

        public AboutService(ApplicationDbContext context)
        {
            _context = context;
        }
        public AboutVM Get(int id)
        {

            var about = _context.About.Select(x => new AboutVM()
            {
                Id = x.Id,
                name = x.name,
                description=x.description,
                email = x.email,
                logo=x.logo,
                phone=x.phone,
                title=x.title,
            }).FirstOrDefault(x => x.Id == id);
            return about;
        }
        public List<AboutVM> GetAll()
        {
            var aboutVm = _context.About.Where(x => x.IsDelete.Equals(false)).OrderByDescending(x => x.Id).Select(x => new AboutVM()
            {
                Id = x.Id,
                name = x.name,
                description = x.description,
                email = x.email,
                logo = x.logo,
                phone = x.phone,
                title = x.title,
            }).ToList();

            return aboutVm;
        }
        public void Create(AboutDTO dto)
        {

            var about = new LocaKey.Data.Entity.About();
            about.name = dto.name;
            about.description = dto.description;
            about.email = dto.email;
            about.phone = dto.phone;
            about.logo= dto.logo;
            about.title= dto.title;

            _context.About.Add(about);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var About = _context.About.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            About.IsDelete = true;
            _context.About.Update(About);
            _context.SaveChanges();
        }



        public void Update(AboutDTO dto)
        {
            var about = _context.About.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);
            about.name = dto.name;
            about.description = dto.description;
            about.email = dto.email;
            about.phone = dto.phone;
            about.logo = dto.logo;
            about.title = dto.title;
            _context.About.Update(about);
            _context.SaveChanges();
        }
    }
}
