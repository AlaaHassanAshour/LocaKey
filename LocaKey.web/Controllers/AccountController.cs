using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.Data.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LocaKey.web.Controllers
{
    public class AccountController : Controller
    {

        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;


        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;

        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM dto, string returnUrl)
        {

            var existingUser = await userManager.FindByNameAsync(dto.Username);
            if (existingUser == null)
            {
                return View(dto);
            }

            var result = await signInManager.PasswordSignInAsync(dto.Username, dto.Password,
                   //Remember Me
                   true,
                   // if he try to login fivetimes then fail close the Account or not
                   true);
            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return LocalRedirect(returnUrl);
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
