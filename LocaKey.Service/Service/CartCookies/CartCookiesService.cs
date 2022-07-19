using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.Service.Service.CartBasket;
using LocaKey.web.Data;
using System.Security.Claims;

namespace LocaKey.Service.Service.CartCookiest
{
    public class CartCookiesService : ICartCookiesService
    {
        private ApplicationDbContext _context;
        public CartCookiesService(ApplicationDbContext context)
        {
            _context = context;
        }
        public CartCookiesVM Get(int id)
        {
            var cart = _context.CartCookies.Select(x => new CartCookiesVM()
            {
                User= new UserVM()
                {
                    fullName= x.User.fullName,
                    Email=x.User.Email,
                    Phone=x.User.PhoneNumber,
                },
                Id = x.Id,
                availableQuantity = x.availableQuantity,
                ProductId = x.ProductId,
                quantitySold = x.quantitySold,
                total = x.total,
              
            }).FirstOrDefault(x => x.Id == id);
            return cart;
        }
        public List<CartCookiesVM> GetAll()
        {
            var cart = _context.CartCookies.Where(x => x.IsDelete.Equals(false)).OrderByDescending(x => x.Id).Select(x => new CartCookiesVM()
            {
                User = new UserVM()
                {
                    fullName = x.User.fullName,
                    Email = x.User.Email,
                    Phone = x.User.PhoneNumber,
                },
                Id = x.Id,
                availableQuantity = x.availableQuantity,
                ProductId = x.ProductId,
                quantitySold = x.quantitySold,
                total = x.total,
            }).ToList();

            return cart;
        }
        public void Create(CartCookiesDTO dto)
        {
           

            var cart = new LocaKey.Data.Entity.CartCookies();
            cart.availableQuantity = dto.availableQuantity;
            cart.ProductId = dto.ProductId;
            cart.quantitySold = dto.quantitySold;
            cart.total = dto.total;
            cart.UserId = dto.UserId;
            _context.CartCookies.Add(cart);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var cart = _context.CartCookies.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            cart.IsDelete = true;
            _context.CartCookies.Update(cart);
            _context.SaveChanges();
        }
        public void Update(CartCookiesDTO dto)
        {
            var cart = _context.CartCookies.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);
            cart.availableQuantity = dto.availableQuantity;
            cart.ProductId = dto.ProductId;
            cart.quantitySold = dto.quantitySold;
            cart.total = dto.total;
            cart.UserId = dto.UserId;
            _context.CartCookies.Update(cart);
            _context.SaveChanges();
        }
    }
}
