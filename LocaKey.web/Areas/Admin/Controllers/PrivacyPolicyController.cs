using LocaKey.Core.DTO;
using LocaKey.Service.Service.privacyPolicy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocaKey.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class PrivacyPolicyController : Controller
    {
        private readonly IprivacyPolicyService _policyService;

        public PrivacyPolicyController(IprivacyPolicyService policyService)
        {
            _policyService = policyService;
        }
        public IActionResult Index()
        {
            return View(_policyService.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(privacyPolicyDTO model)
        {
            _policyService.Create(model);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(_policyService.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(privacyPolicyDTO model)
        {
            _policyService.Update(model);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(_policyService.Get(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _policyService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
