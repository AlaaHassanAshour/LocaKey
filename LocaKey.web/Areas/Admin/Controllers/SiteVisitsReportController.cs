using LocaKey.Core.DTO;
using LocaKey.Service.Service.SiteVisitsReport;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocaKey.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SiteVisitsReportController : Controller
    {
        private readonly ISiteVisitsReportService _siteVisitsReportService;

        public SiteVisitsReportController(ISiteVisitsReportService siteVisitsReportService)
        {
            _siteVisitsReportService = siteVisitsReportService;
        }
        public IActionResult Index()
        {
            return View(_siteVisitsReportService.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SiteVisitsReportDTO model)
        {
            _siteVisitsReportService.Create(model);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(_siteVisitsReportService.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(SiteVisitsReportDTO model)
        {
            _siteVisitsReportService.Update(model);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(_siteVisitsReportService.Get(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _siteVisitsReportService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
