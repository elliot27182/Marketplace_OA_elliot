using RepositoryLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using DomainLayer.Interfaces;

namespace RepositoryLayer
{
    public class ProductAttributesRepo : GenericRepo<Product_Attributes>, IProductAttributesRepo
    {
        public ProductAttributesRepo(MarketDBContext context) : base(context)
        {
        }

        public IEnumerable<Product_Attributes> GetProductAttributeByID(int id)
        {
            //return Context.Set<Product_Attributes>().Where(p => p.ProductsID == id).ToList();
            return Context.Set<Product_Attributes>()
            .Include("Attributes")
            .Include("Attribute_Values")
            .Include("Products")
            .Where(p => p.ProductsID == id).ToList();
        }
    }

}
