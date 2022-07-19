using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.SalesReport
{
    public class SalesReportService: ISalesReportService
    {

        private ApplicationDbContext _context;

        public SalesReportService(ApplicationDbContext context)
        {
            _context = context;
        }
        public SalesReportVM Get(int id)
        {

            var SalesReport = _context.SalesReport.Select(x => new SalesReportVM()
            {
                Id = x.Id,
               basePrice=x.basePrice,
               count = x.count,
               priceWitheBuying=x.priceWitheBuying,
               productBuying=x.productBuying,
               total=x.total
            }).FirstOrDefault(x => x.Id == id);
            return SalesReport;
        }
        public List<SalesReportVM> GetAll()
        {
            var SalesReport = _context.SalesReport.Where(x => x.IsDelete.Equals(false)).OrderByDescending(x => x.Id).Select(x => new SalesReportVM()
            {
                Id = x.Id,
                basePrice = x.basePrice,
                count = x.count,
                priceWitheBuying = x.priceWitheBuying,
                productBuying = x.productBuying,
                total = x.total
            }).ToList();

            return SalesReport;
        }
        public void Create(SalesReportDTO dto)
        {

            var SalesReportDTO = new LocaKey.Data.Entity.SalesReport();
            SalesReportDTO.basePrice = dto.basePrice;
            SalesReportDTO.count = dto.count;
            SalesReportDTO.priceWitheBuying = dto.priceWitheBuying;
            SalesReportDTO.productBuying = dto.productBuying;
            SalesReportDTO.total = dto.total;

            _context.SalesReport.Add(SalesReportDTO);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _context.SalesReport.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            category.IsDelete = true;
            _context.SalesReport.Update(category);
            _context.SaveChanges();
        }



        public void Update(SalesReportDTO dto)
        {
            var SalesReportDTO = new LocaKey.Data.Entity.SalesReport();
            SalesReportDTO.basePrice = dto.basePrice;
            SalesReportDTO.count = dto.count;
            SalesReportDTO.priceWitheBuying = dto.priceWitheBuying;
            SalesReportDTO.productBuying = dto.productBuying;
            SalesReportDTO.total = dto.total;

            _context.SalesReport.Update(SalesReportDTO);
            _context.SaveChanges();
        }
    }
}
