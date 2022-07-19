using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.web.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LocaKey.web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class Auth : Controller
    {
        private ApplicationDbContext _DB;
        private SignInManager<LocaKey.Data.Entity.User> _signInManager;
        private readonly UserManager<LocaKey.Data.Entity.User> _userManager;
        public Auth(ApplicationDbContext DB, SignInManager<LocaKey.Data.Entity.User> signInManager, UserManager<LocaKey.Data.Entity.User> userManager)
        {
            _DB = DB;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var users = _DB.Users.Where(x => !x.IsDelete).Select(x => new UserVM()
            {
                Email = x.Email,
                fullName = x.fullName,
                Phone = x.PhoneNumber
            }).ToList();

            return View(users);
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO dto)
        {
            if (_DB.Users.Any(x => x.Email == dto.Email || x.PhoneNumber == dto.phone))
            {
                return NotFound();
            }
            var user = new LocaKey.Data.Entity.User()
            {
                fullName = dto.fullname,
                UserName = dto.fullname,
                Email = dto.Email,
                PhoneNumber = dto.phone
            };

            var result = await _userManager.CreateAsync(user, dto.Password);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
               // await _userManager.AddToRoleAsync(user, "Admin");
                return Redirect("/Admin/home/index");
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO dto)
        {
            var user = _DB.Users.SingleOrDefault(x => x.UserName == dto.Username && !x.IsDelete);

            if (user == null)
            {
                return BadRequest();
            }
            var result = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password,
                          //Remember Me
                          true,
                          // if he try to login fivetimes then fail close the Account or not
                          true);
         //   var result = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, false);

            if (result.Succeeded)
            {

                return Redirect("/Admin/home/index");

            }
            return BadRequest();
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
