using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.privacyPolicy
{
    public interface IprivacyPolicyService
    {
        privacyPolicyVM Get(int id);
        List<privacyPolicyVM> GetAll();
        void Create(privacyPolicyDTO dto);
        void Delete(int id);
        void Update(privacyPolicyDTO entity);
    }
}
