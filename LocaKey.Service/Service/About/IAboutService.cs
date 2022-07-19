using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.About
{
    public interface IAboutService
    {
        AboutVM Get(int id);
        List<AboutVM> GetAll();

        void Delete(int id);

        void Create(AboutDTO dto);

        void Update(AboutDTO entity);
    }
}
