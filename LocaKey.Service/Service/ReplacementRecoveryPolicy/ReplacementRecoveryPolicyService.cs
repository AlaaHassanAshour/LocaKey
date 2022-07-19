using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using LocaKey.web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.ReplacementRecoveryPolicy
{
    public class ReplacementRecoveryPolicyService: IReplacementRecoveryPolicyService
    {
        private ApplicationDbContext _context;

        public ReplacementRecoveryPolicyService(ApplicationDbContext context)
        {
            _context = context;
        }
        public ReplacementRecoveryPolicyVM Get(int id)
        {

            var ReplacementRecoveryPolicyVM = _context.ReplacementRecoveryPolicy.Select(x => new ReplacementRecoveryPolicyVM()
            {
                Id = x.Id,
                name = x.name,
                description = x.description,
                IpAddress = x.IpAddress,
                MacAddress=x.MacAddress
            }).FirstOrDefault(x => x.Id == id);
            return ReplacementRecoveryPolicyVM;
        }
        public List<ReplacementRecoveryPolicyVM> GetAll()
        {
            var ReplacementRecoveryPolicyVM = _context.ReplacementRecoveryPolicy.Where(x => x.IsDelete.Equals(false)).OrderByDescending(x => x.Id).Select(x => new ReplacementRecoveryPolicyVM()
            {
                Id = x.Id,
                name = x.name,
                description = x.description,
                IpAddress = x.IpAddress,
                MacAddress = x.MacAddress
            }).ToList();

            return ReplacementRecoveryPolicyVM;
        }
        public void Create(ReplacementRecoveryPolicyDTO dto)
        {

            var ReplacementRecoveryPolicy = new LocaKey.Data.Entity.ReplacementRecoveryPolicy();
            ReplacementRecoveryPolicy.name = dto.name;
            ReplacementRecoveryPolicy.description = dto.description;
            ReplacementRecoveryPolicy.IpAddress = dto.IpAddress;
            ReplacementRecoveryPolicy.MacAddress = dto.MacAddress;

            _context.ReplacementRecoveryPolicy.Add(ReplacementRecoveryPolicy);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ReplacementRecoveryPolicy = _context.ReplacementRecoveryPolicy.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            ReplacementRecoveryPolicy.IsDelete = true;
            _context.ReplacementRecoveryPolicy.Update(ReplacementRecoveryPolicy);
            _context.SaveChanges();
        }



        public void Update(ReplacementRecoveryPolicyDTO dto)
        {
            var ReplacementRecoveryPolicy = _context.ReplacementRecoveryPolicy.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);
            ReplacementRecoveryPolicy.name = dto.name;
            ReplacementRecoveryPolicy.description = dto.description;
            ReplacementRecoveryPolicy.IpAddress = dto.IpAddress;
            ReplacementRecoveryPolicy.MacAddress = dto.MacAddress;
            _context.ReplacementRecoveryPolicy.Update(ReplacementRecoveryPolicy);
            _context.SaveChanges();
        }
    }
}

