using LocaKey.Core.DTO;
using LocaKey.Service.Service.Coupons;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocaKey.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class CouponsController : Controller
    {

        private readonly ICouponsService _couponsService;

        public CouponsController(ICouponsService couponsService)
        {
            _couponsService = couponsService;
        }
        public IActionResult Index()
        {
            return View(_couponsService.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CouponsDTO model)
        {
            _couponsService.Create(model);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(_couponsService.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(CouponsDTO model)
        {
            _couponsService.Update(model);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(_couponsService.Get(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _couponsService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}