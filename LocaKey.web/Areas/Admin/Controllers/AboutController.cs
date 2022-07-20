using LocaKey.Core.DTO;
using LocaKey.Service.Service.About;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocaKey.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public AboutController(IAboutService aboutService, IWebHostEnvironment hostingEnvironment)
        {
            _aboutService = aboutService;
            _hostingEnvironment = hostingEnvironment;   
        }
        public IActionResult Index()
        {
            return View(_aboutService.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AboutDTO model)
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
            model.logo = imegPath;
            _aboutService.Create(model);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(_aboutService.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(AboutDTO model)
        {
            _aboutService.Update(model);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return View(_aboutService.Get(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _aboutService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
