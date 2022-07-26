using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.Data.Entity;
using LocaKey.web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> AddCart(int id)
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var cart = new LocaKey.Data.Entity.CartCookies();
            cart.UserId = claim.Value;
            cart.ProductId = id;
            cart.PickUpTime = DateTime.Now;
            cart.totalprice = 0;
            cart.total = 1;
            float total = 0;
            var carts = await _context.CartCookies.Include(x => x.Product).Where(m => m.UserId == claim.Value && !m.IsDelete).ToListAsync();
            foreach (var item in carts)
            {
                total += item.totalprice;
            }
            ViewBag.totalprice = total;
            _context.CartCookies.Add(cart);
            cart.totalprice = cart.Product.price_ar * cart.total;
            _context.SaveChanges();
            return PartialView("_AddCart", carts);
        }
        [HttpGet]
        public IActionResult CartShopping()
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var carts = _context.CartCookies.Include(x => x.Product).Where(m => m.UserId == claim.Value && !m.IsDelete).Select(x => new CartCookiesVM()
            {
                Product = new Product()
                {
                    name_ar = x.Product.name_ar,
                    price_ar = x.Product.price_ar,
                    imege = x.Product.imege,
                },
                total = x.total,
                Id = x.Id,
            }).OrderByDescending(x => x.Id).ToList();
            if (carts != null)
            {
                return View(carts);
            }
            return NotFound();
        }
        public IActionResult Plus(int cartId)
        {
            var shoppingCart = _context.CartCookies.Include(x => x.Product).SingleOrDefault(x => x.Id == cartId);
            shoppingCart.total += 1;
            shoppingCart.totalprice = shoppingCart.total * shoppingCart.Product.price_ar;

            // _context.Update(shoppingCart);
            _context.SaveChanges();
            return RedirectToAction(nameof(CartShopping));
        }
        public IActionResult Minus(int cartId)
        {
            var shoppingCart = _context.CartCookies.Include(x => x.Product).SingleOrDefault(x => x.Id == cartId);
            shoppingCart.total -= 1;
            shoppingCart.totalprice = shoppingCart.total * shoppingCart.Product.price_ar;
            //_context.Update(shoppingCart);
            _context.SaveChanges();
            return RedirectToAction(nameof(CartShopping));
        }
        public IActionResult Remove(int cartId)
        {
            var shoppingCart = _context.CartCookies.SingleOrDefault(x => x.Id == cartId);
            shoppingCart.IsDelete = true;
            _context.Update(shoppingCart);
            _context.SaveChanges();
            return RedirectToAction(nameof(CartShopping));
        }
    }
}