using LocaKey.Core.ViweModel;
using LocaKey.web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LocaKey.web.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string name , int? prouductId, int page)
        { 
            ViewData["categorys"] = new SelectList(_context.Categorys.ToList(), "Id", "nameAr");
            ViewBag.SearchName = name;
            var totalCount = _context.Products.Count(x => !x.IsDelete && (x.name_ar.Contains(name)  || x.description_ar.Contains(name) || x.price_ar.ToString().Contains(name) || String.IsNullOrEmpty(name)) && (x.CategoryId == prouductId || prouductId == null));
            var dataPerBage = 6.0;
            var numberofpage = Math.Ceiling(totalCount/ dataPerBage);
            if (page < 1 || page > numberofpage)
            {
                page = 1;
            }
            var skipVal = (page - 1) * dataPerBage;
            var data = _context.Products.Where(x=>!x.IsDelete &&( x.name_ar.Contains(name) || x.description_ar.Contains(name) || x.price_ar.ToString().Contains(name) || String.IsNullOrEmpty(name))&&( x.CategoryId == prouductId || prouductId==null)).Skip((int)skipVal).Take((int)dataPerBage).ToList();
            var result = new PageingViweModel();
            result.CurrantPage = page;
            result.NumberOfPages = (int)numberofpage;
            result.Data = data;
            return View(result);
        }
    }
}
