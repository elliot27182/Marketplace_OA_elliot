using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{
    public interface IProductsAttributesRepo2
    {
        IEnumerable<ProductAttributeDetail> GetProductAttributeByID2(int id);
        IEnumerable<Products> GetProductsByCategory(int CategoryId);
    }
}
