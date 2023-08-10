using RepositoryLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using DomainLayer.Interfaces;
using System.Data.Entity;


namespace RepositoryLayer.Repositories
{
    public class ProductAttributesRepo2 : GenericRepo<ProductAttributeDetail>, IProductsAttributesRepo2
    {
        public ProductAttributesRepo2(MarketDBContext context) : base(context)
        {
        }

        public IEnumerable<ProductAttributeDetail> GetProductAttributeByID2(int id)

        {


            var result = from p in Context.Products
                         where p.ProductsID == id
                         join pa in Context.Product_Attributes on p.ProductsID equals pa.ProductsID
                         join a in Context.Attributes on pa.AttributesID equals a.AttributesID
                         from av in Context.Attribute_Values
                            .Where(av => pa.Discrete_Attribute_Value_ID == av.Attribute_ValuesID).DefaultIfEmpty()
                         select new ProductAttributeDetail
                         {
                             ProductsID = p.ProductsID,
                             Product_Name = p.Product_Name,
                             Description = p.Description,
                             Image_URL = p.Image_URL,
                             CategoriesID = (int)p.CategoriesID,
                             AttributesID = pa.AttributesID,
                             Attribute_Name = a.Attribute_Name,
                             Attribute_ValuesID = av == null ? 0 : av.Attribute_ValuesID,
                             Attribute_Value = av == null ? string.Empty : av.Attribute_Value,

                         };



            return result.ToList();
        }

        public IEnumerable<Products> GetProductsByCategory(int CategoryId)
        {

            var ProductsList = Context.Set<Products>().Where(category => category.CategoriesID == CategoryId);

            return ProductsList.ToList();
        }
    }
}
