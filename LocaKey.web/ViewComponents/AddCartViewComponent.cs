using LocaKey.web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace LocaKey.web.Component
{
    public class AddCartViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public AddCartViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var cart = new LocaKey.Data.Entity.CartCookies();
            cart.UserId = claim.Value;
            cart.ProductId = id;
            cart.PickUpTime = DateTime.Now;
      
            var carts = await _context.CartCookies.Include(x => x.Product).Where(m => m.UserId == claim.Value && !m.IsDelete).ToListAsync();
            foreach (var item in carts)
            {
                cart.total = item.Product.count;
                cart.totalprice += item.total * item.Product.price_ar;
            }
            ViewBag.totalprice = cart.totalprice;
            _context.CartCookies.Add(cart);
            _context.SaveChanges();
            return View(carts);
        }
    }
}