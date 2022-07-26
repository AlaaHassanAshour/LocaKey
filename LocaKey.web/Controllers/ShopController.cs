using LocaKey.web.Data;
using Microsoft.AspNetCore.Mvc;

namespace LocaKey.web.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products=_context.Products.Where(x=>!x.IsDelete).ToList();
            return View(products);
        }
    }
}
