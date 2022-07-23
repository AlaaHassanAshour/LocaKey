using LocaKey.Core.DTO;
using LocaKey.web.Data;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LocaKey.web.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var shoppingCarts = _context.CartCookies.Where(m => m.UserId == claim.Value);
            if (shoppingCarts != null)
            {
                return View(shoppingCarts);
            }

            return View();
        }
        public IActionResult AddCart(int id)
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var cart = new LocaKey.Data.Entity.CartCookies();
            cart.UserId = claim.Value;
            cart.ProductId = id;
            var product = _context.Products.Where(m => m.Id == id&& !m.IsDelete).ToList();
            cart.total= product.Count;
            foreach (var item in product)
            {
                cart.totalprice += item.count * item.price_ar;
            }       
            cart.PickUpTime = DateTime.Now;
            _context.CartCookies.Add(cart);
            _context.SaveChanges(); 
            return View();
        }
    }
}