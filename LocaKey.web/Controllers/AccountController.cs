using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.Data.Entity;
using LocaKey.web.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LocaKey.web.Controllers
{
    public class AccountController : Controller
    {

        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly ApplicationDbContext _context;



        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager, ApplicationDbContext context)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            _context = context;
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

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO dto)
        {
            if (_context.Users.Any(x => x.Email == dto.Email || x.PhoneNumber == dto.phone))
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

            var result = await userManager.CreateAsync(user, dto.Password);
            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, false);
                // await _userManager.AddToRoleAsync(user, "Admin");
                var clint = new Client()
                {
                    country = dto.country,
                    UserId = user.Id,
                };
                _context.Add(clint);
                _context.SaveChanges();
                return Redirect("/home/index");
            }
            return NotFound();
        }

    }
}