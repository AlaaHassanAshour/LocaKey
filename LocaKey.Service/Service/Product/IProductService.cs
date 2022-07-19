using LocaKey.Core.DTO;
using LocaKey.Core.ViweModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaKey.Service.Service.Product
{
    public interface IProductService
    {
        ProductVM Get(int id);
        List<ProductVM> GetAll(int? categoryId, int? count);

        void Delete(int id);

        void Create(ProductDTO dto);

        void Update(ProductDTO entity);

    }
}
