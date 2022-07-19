using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.Data.Entity;
using LocaKey.web.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.Atho
{
    public class AthoServise
    {

        //public class AuthService : IAuthService
        //{
        //    private ApplicationDbContext _DB;
        //    private SignInManager<User> _signInManager;
        //    private readonly UserManager<User> _userManager;
        //    public AuthService(ApplicationDbContext DB, SignInManager<User> signInManager, UserManager<User> userManager)
        //    {
        //        _DB = DB;
        //        _signInManager = signInManager;
        //        _userManager = userManager;
        //    }

        //    public async Task<RegisterVM> Create(RegisterDTO dto)
        //    {
        //        if (_DB.Users.Any(x => x.Email == dto.Email || x.PhoneNumber == dto.phone))
        //        {
        //            return null;
        //        }
        //        var user = new User();
        //        user.fullName = dto.fullname;
        //        user.Email = dto.Email;
        //        user.PhoneNumber = dto.phone;
        //        user.password = dto.password;


        //        var result = await _userManager.CreateAsync(user, user.password);
        //        if (result.Succeeded)
        //        {

        //            await _userManager.AddToRoleAsync(user, "Admin");
        //            else if (user.UserType == Enums.UserType.User)
        //            {
        //                await _userManager.AddToRoleAsync(user, "User");
        //            }
        //            else if (user.UserType == Enums.UserType.OrginastionAdmin)
        //            {
        //                await _userManager.AddToRoleAsync(user, "OrganazationAdmin");
        //            }
        //        }
        //        return null;
        //    }

        //    public async Task<LoginVM> LoginAsync(LoginDTO dto)
        //    {
        //        var user = _DB.Users.SingleOrDefault(x => x.UserName == dto.Username && !x.IsDelete);

        //        if (user == null)
        //        {
        //            return null;
        //        }

        //        var result = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, false);

        //        if (result.Succeeded)
        //        {

        //            _DB.Users.Update(user);
        //            _DB.SaveChanges();
        //            return response;
        //        }
        //        return null;
        //    }

        //}
    }

}
