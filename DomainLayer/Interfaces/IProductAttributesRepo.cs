using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{

    public interface IProductAttributesRepo : IGenericRepo<Product_Attributes>
    {
        IEnumerable<Product_Attributes> GetProductAttributeByID(int id);
    }

}
