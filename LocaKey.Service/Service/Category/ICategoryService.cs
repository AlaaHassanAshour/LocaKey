using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.Category
{
    public interface ICategoryService
    {
        CategoryVM Get(int id);
        List<CategoryVM> GetAll();

        void Delete(int id);

        void Create(CategoryDTO dto);

        void Update(CategoryDTO entity);


    }
}
