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
    public class ProductsRepo : GenericRepo<Products>, IProductsRepo
    {
        public ProductsRepo(MarketDBContext context) : base(context)
        {
        }

        public IEnumerable<ProductAttributeDetail> GetProductAttributeByID(int productId)
        {
            throw new NotImplementedException();
        }
    }

}
