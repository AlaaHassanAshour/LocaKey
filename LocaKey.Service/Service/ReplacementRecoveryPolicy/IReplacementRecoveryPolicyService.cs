using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.ReplacementRecoveryPolicy
{
    public interface IReplacementRecoveryPolicyService
    {
        ReplacementRecoveryPolicyVM Get(int id);
        List<ReplacementRecoveryPolicyVM> GetAll();
        void Create(ReplacementRecoveryPolicyDTO dto);
        void Delete(int id);
        void Update(ReplacementRecoveryPolicyDTO entity);
    }
}
