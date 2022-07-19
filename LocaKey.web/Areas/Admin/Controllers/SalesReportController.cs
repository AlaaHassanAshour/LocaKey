using LocaKey.Core.DTO;
using LocaKey.Service.Service.SalesReport;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocaKey.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SalesReportController : Controller
    {
        private readonly ISalesReportService _salesReportService;

        public SalesReportController(ISalesReportService salesReportService)
        {
            _salesReportService = salesReportService;
        }
        public IActionResult Index()
        {
            return View(_salesReportService.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SalesReportDTO model)
        {
            _salesReportService.Create(model);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(_salesReportService.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(SalesReportDTO model)
        {
            _salesReportService.Update(model);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(_salesReportService.Get(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _salesReportService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
