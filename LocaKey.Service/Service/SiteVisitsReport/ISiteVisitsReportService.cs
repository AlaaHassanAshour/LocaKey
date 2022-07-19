using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.SiteVisitsReport
{
    public interface ISiteVisitsReportService
    {
        SiteVisitsReportVM Get(int id);
        List<SiteVisitsReportVM> GetAll();
        void Create(SiteVisitsReportDTO dto);
        void Delete(int id);
        void Update(SiteVisitsReportDTO dto);

    }
}
