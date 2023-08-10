using ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface IProductGetAttributeService
    {

        IEnumerable<ProductAttributeDetailDTO> GetProductById(int ProductID);
        IEnumerable<ProductsDTO> GetProductsByCategory(int CategoryId);
    }
}
