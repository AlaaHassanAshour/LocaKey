using LocaKey.Core.ViweModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocaKey.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var dashbord = new DashabordVM()
            {

            };
            return View();
        }
    }
}
