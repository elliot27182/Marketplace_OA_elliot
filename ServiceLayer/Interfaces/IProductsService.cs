using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Models;

namespace ServiceLayer.Interfaces
{

    public interface IProductsService
    { 
        IEnumerable<ProductsDTO> GetAllProducts();

        IEnumerable<ProductsDTO> GetProductsByCategory(int CategoryId);

        IEnumerable<ProductAttributeDetailDTO> GetProductAttributeByID(int productId);
    }

}