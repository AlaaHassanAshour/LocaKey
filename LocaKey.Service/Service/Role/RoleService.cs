using LocaKey.Core.ViweModel;
using LocaKey.web.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.Role
{
    public class RoleService: IRoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        public RoleService(RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
        {
            _roleManager = roleManager;
            _db = db;
        }
        public List<RoleVM> Index()
        {
            var roles = _db.Roles.Select(x => new RoleVM()
            {
                Name = x.Name,
                Id = x.Id
            }).ToList();

          
            return roles;
        }
        //public async Task InitRole()
        //{
        //    var role = new List<string>();
        //    role.Add("");
        //    role.Add("");
        //    role.Add("");
        //    foreach (var item in role)
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(item));
        //    }
        //}
    }
}
