using AutoMapper;
using DomainLayer.Interfaces;
using DomainLayer.Models;
using RepositoryLayer;
using RepositoryLayer.Repositories;
using ServiceLayer.Interfaces;
using ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ProductAttributesService : IProductAttributesService
    {
        MarketDBContext context = new MarketDBContext();
        private Mapper mapper;
        public IUnitOfWork _unitOfWork;
        public ProductAttributesService()
        {
            context = new MarketDBContext();
            _unitOfWork = new UnitOfWork(context);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product_Attributes, Product_AttributesDTO>();

            });
            mapper = new Mapper(config);
        }

        IEnumerable<Product_AttributesDTO> IProductAttributesService.GetProductAttributes(int ProductID)
        {


            // Mapping Product to ProductDTO using AutoMapper

            //var productAttributes = mapper.Map<List<Product_AttributesDTO>>(_unitOfWork.ProductAttributesRepo.GetProductAttributeByID(ProductID));

            IEnumerable<Product_Attributes> productAttributes = _unitOfWork.ProductAttributesRepo.GetProductAttributeByID(ProductID);
            IEnumerable<Product_AttributesDTO> productDetail = productAttributes
            .Where(pa => pa.Attributes != null && pa.Attribute_Values != null)
            .Select(productAttribute => new Product_AttributesDTO
            {
                ProductsID = productAttribute.ProductsID,
                AttributesID = productAttribute.AttributesID,
                Attribute_Name = productAttribute.Attributes.Attribute_Name,
                Attribute_Value_ID = productAttribute.Discrete_Attribute_Value_ID,
                Attribute_Value = productAttribute.Attribute_Values.Attribute_Value,
                Value_Type = productAttribute.Attributes.Value_Type

                //Product_Name = productAttribute.Products.Product_Name,
                //Description = productAttribute.Products.Description,
                //Image_URL = productAttribute.Products.Image_URL
            });

            return productDetail;


        }
    }
}
