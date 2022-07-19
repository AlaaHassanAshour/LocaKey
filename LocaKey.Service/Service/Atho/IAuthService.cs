using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.Atho
{
    public interface IAuthService
    {
        Task<LoginVM> LoginAsync(LoginDTO dto);
    }
}
