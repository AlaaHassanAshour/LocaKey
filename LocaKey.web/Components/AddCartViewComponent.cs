using LocaKey.web.Data;
using Microsoft.AspNetCore.Mvc;
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
            var product = _context.Products.Where(m => m.Id == id && !m.IsDelete).ToList();
            cart.total = product.Count;
            foreach (var item in product)
            {
                cart.totalprice += item.count * item.price_ar;
            }
            cart.PickUpTime = DateTime.Now;
            _context.CartCookies.Add(cart);
            _context.SaveChanges();

//            var cart = _
            return View(product);
        }
    }
}