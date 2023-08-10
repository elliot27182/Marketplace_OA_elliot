using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DomainLayer.Interfaces;
using DomainLayer.Models;
using RepositoryLayer;
using RepositoryLayer.Repositories;
using ServiceLayer.Interfaces;
using ServiceLayer.Models;

namespace ServiceLayer
{
    public class MCService : IMainCategoriesService, ICategoriesService, IProductGetAttributeService, IAttributesService

    {
        private readonly MarketDBContext context;

        private Mapper mapper;

        public IUnitOfWork _unitOfWork;

        public MCService()
        {
            context = new MarketDBContext();

            _unitOfWork = new UnitOfWork(context);

            //mapper = new Mapper(new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Categories, CategoriesDTO>();
            //}));


        }

        

        IEnumerable<MainCategoriesDTO> IMainCategoriesService.GetAllMainCategories()

        {
            var mainCategories = _unitOfWork.MainCategoriesRepo.GetAll();

            List<MainCategoriesDTO> mainCategoriesDTO = new List<MainCategoriesDTO>();

            foreach (var mainCategory in mainCategories)
            {
                mainCategoriesDTO.Add(new MainCategoriesDTO
                {
                    MainCategoriesID = mainCategory.MainCategoriesID,
                    Main_Category_Name = mainCategory.Main_Category_Name,
                });
            }

            return mainCategoriesDTO;
        }
        IEnumerable<CategoriesDTO> ICategoriesService.GetCategoryById(int MainCategoryId)
        {
            var categories = _unitOfWork.CategoriesRepo.GetCategoryById(MainCategoryId);

            List<CategoriesDTO> categoriesDTO = new List<CategoriesDTO>();
            foreach (var category in categories)
            {
                categoriesDTO.Add(new CategoriesDTO
                {
                    CategoriesID = category.CategoriesID,
                    Category_Name = category.Category_Name,
                    MainCategoriesID = category.MainCategoriesID,
                });
            }
            return categoriesDTO;

            //return mapper.Map<List<CategoriesDTO>>(categories);
        }

        IEnumerable<ProductAttributeDetailDTO> IProductGetAttributeService.GetProductById(int ProductID)
        {
            var productAttributeDetail = _unitOfWork.ProductsAttributesRepo.GetProductAttributeByID2(ProductID);
            List<ProductAttributeDetailDTO> productAttributeDetailDTO = new List<ProductAttributeDetailDTO>();
            foreach (var item in productAttributeDetail)
            {
                productAttributeDetailDTO.Add(new ProductAttributeDetailDTO
                {
                    ProductsID = item.ProductsID,
                    Product_Name = item.Product_Name,
                    Description = item.Description,
                    CategoriesID = item.CategoriesID,
                    AttributesID = item.AttributesID,
                    Attribute_Name = item.Attribute_Name,
                    Attribute_Value = item.Attribute_Value,
                    Image_URL = item.Image_URL

                });
            }
            return productAttributeDetailDTO;

        }

        IEnumerable<ProductsDTO> IProductGetAttributeService.GetProductsByCategory(int CategoryId)
        {
            var products = _unitOfWork.ProductsAttributesRepo.GetProductsByCategory(CategoryId);

            List<ProductsDTO> productsDTO = new List<ProductsDTO>();
            foreach (var product in products)
            {
                productsDTO.Add(new ProductsDTO
                {
                    ProductsID = product.ProductsID,
                    Product_Name = product.Product_Name,
                    Description = product.Description,
                    CategoriesID = product.CategoriesID,
                    Image_URL = product.Image_URL,


                });
            }

            return productsDTO;
        }

        IEnumerable<AttributesDTO> IAttributesService.GetAttributesByCategoryId(int attributeId)
        {
            var Attributes = _unitOfWork.AttributesRepo.GetAttributesByCategoryId(attributeId);

            List<AttributesDTO>  attributesDTO = new List<AttributesDTO>();

            foreach (var attribute in Attributes)
            {
                attributesDTO.Add(new AttributesDTO
                {
                    AttributesID = attribute.AttributesID,
                    Attribute_Name = attribute.Attribute_Name,
                    min_value = attribute.min_value,
                    max_value = attribute.max_value,
                    Value_Type = attribute.Value_Type,
                    CategoriesID = attribute.CategoriesID,
                });
            }
            return attributesDTO;
        }

        //public IEnumerable<Products> GetProductsByCategory(int CategoryId)
        //{
        //    var products = _unitOfWork.ProductsRepo.GetProductsByCategory(CategoryId);

        //    return (IEnumerable<Products>)mapper.Map<List<ProductsDTO>>(products);
        //}

    }


}
