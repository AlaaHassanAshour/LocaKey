using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.Language
{
    public interface ILanguageService
    {
        LanguageVM Get(int id);
        List<LanguageVM> GetAll();

        void Delete(int id);

        void Create(LanguageDTO dto);

        void Update(LanguageDTO entity);
    }
}
