using LocaKey.Core.DTO;
using LocaKey.Service.Service.CartBasket;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LocaKey.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class CartCookiesController : Controller
    {
        private readonly ICartCookiesService _cartCookiesService;

        public CartCookiesController(ICartCookiesService cartCookiesService)
        {
            _cartCookiesService = cartCookiesService;
        }
        public IActionResult Index()
        {
            return View(_cartCookiesService.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CartCookiesDTO model)
        {
            _cartCookiesService.Create(model);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(_cartCookiesService.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(CartCookiesDTO model)
        {
            _cartCookiesService.Update(model);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(_cartCookiesService.Get(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _cartCookiesService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}