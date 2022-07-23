using LocaKey.Core.ViweModel;
using LocaKey.web.Data;
using Microsoft.AspNetCore.Mvc;
namespace LocaKey.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            HomeProductVM homeProductVM = new HomeProductVM()
            {
                category = _context.Categorys.Where(x => x.IsDelete.Equals(false)).ToList(),
                product = _context.Products.Where(x => x.IsDelete.Equals(false)).ToList()
            };
            return View(homeProductVM);
        }
        public IActionResult Contact()
        {
            var contactVM = new ContactVM()
            {
                about = _context.About.SingleOrDefault(x => x.Id == 8),
            };

            return View(contactVM);
        }
        [HttpPost]
        public IActionResult ContactPost(ContactVM model)
        {
            _context.Contact.Add(model.contact);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult About()
        {

            return View(_context.About.SingleOrDefault(x => x.Id == 8));
        }
        public IActionResult Detailes(int id)
        {
            var detailes = _context.Products.SingleOrDefault(x => x.Id == id);
            return View(detailes);
        }
    }
}