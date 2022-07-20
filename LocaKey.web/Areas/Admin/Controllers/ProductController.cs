using LocaKey.Core.DTO;
using LocaKey.Data.Entity;
using LocaKey.Service.Service.Category;
using LocaKey.Service.Service.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LocaKey.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public ProductController(IProductService productService, ICategoryService categoryService, IWebHostEnvironment hostingEnvironment)
        {
            _productService = productService;
            _categoryService = categoryService;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index(int? categoryId, int? count)
        {
         
            ViewBag.count=count;
            ViewData["categoryId"] = new SelectList(_categoryService.GetAll(), "Id", "nameAr");
            return View(_productService.GetAll(categoryId,count));
        }
        public IActionResult Create()
        {
            ViewData["categoryId"] = new SelectList(_categoryService.GetAll(), "Id", "nameAr");
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductDTO model)
        {
            string imegPath = @"default.jpg";
            var files = HttpContext.Request.Form.Files;
            if (files.Count > 0)
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                string ImegName = DateTime.Now.ToFileTime().ToString() + Path.GetExtension(files[0].FileName);
                FileStream fileStream = new FileStream(Path.Combine(webRootPath, "Images", ImegName), FileMode.Create);
                files[0].CopyTo(fileStream);
                imegPath = ImegName;
            }
            model.imege = imegPath;
           
            _productService.Create(model);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(_productService.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(ProductDTO model)
        {
            _productService.Update(model);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(_productService.Get(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _productService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
