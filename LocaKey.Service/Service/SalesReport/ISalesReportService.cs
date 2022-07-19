using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.SalesReport
{
    public interface ISalesReportService
    {
        SalesReportVM Get(int id);
        List<SalesReportVM> GetAll();
        void Create(SalesReportDTO dto);
        void Delete(int id);
        void Update(SalesReportDTO dto);
    }
}
