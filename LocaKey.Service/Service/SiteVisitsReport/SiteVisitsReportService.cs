using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.SiteVisitsReport
{
    public class SiteVisitsReportService: ISiteVisitsReportService
    {
        private ApplicationDbContext _context;

        public SiteVisitsReportService(ApplicationDbContext context)
        {
            _context = context;
        }
        public SiteVisitsReportVM Get(int id)
        {

            var SiteVisitsReportVM = _context.SiteVisitsReport.Select(x => new SiteVisitsReportVM()
            {
                Id = x.Id,
              IpAddress = x.IpAddress,
              MacAddress = x.MacAddress,
              site_visit=x.site_visit,
              
            }).FirstOrDefault(x => x.Id == id);
            return SiteVisitsReportVM;
        }
        public List<SiteVisitsReportVM> GetAll()
        {
            var SiteVisitsReportVM = _context.SiteVisitsReport.Where(x => x.IsDelete.Equals(false)).OrderByDescending(x => x.Id).Select(x => new SiteVisitsReportVM()
            {
                Id = x.Id,
                IpAddress = x.IpAddress,
                MacAddress = x.MacAddress,
                site_visit = x.site_visit,

            }).ToList();

            return SiteVisitsReportVM;
        }
        public void Create(SiteVisitsReportDTO dto)
        {

            var SiteVisitsReportDTO = new LocaKey.Data.Entity.SiteVisitsReport();
            SiteVisitsReportDTO.site_visit = dto.site_visit;
            SiteVisitsReportDTO.IpAddress = dto.IpAddress;
            SiteVisitsReportDTO.MacAddress = dto.MacAddress;
            _context.SiteVisitsReport.Add(SiteVisitsReportDTO);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var SiteVisitsReport = _context.SiteVisitsReport.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            SiteVisitsReport.IsDelete = true;
            _context.SiteVisitsReport.Update(SiteVisitsReport);
            _context.SaveChanges();
        }



        public void Update(SiteVisitsReportDTO dto)
        {

            var SiteVisitsReport = new LocaKey.Data.Entity.SiteVisitsReport();
            SiteVisitsReport.site_visit = dto.site_visit;
            SiteVisitsReport.IpAddress = dto.IpAddress;
            SiteVisitsReport.MacAddress = dto.MacAddress;

            _context.SiteVisitsReport.Update(SiteVisitsReport);
            _context.SaveChanges();
        }
    }
}
