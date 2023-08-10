using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceLayer;
using ServiceLayer.Interfaces;
using Marketplace_OA.Models;
using AutoMapper;
using ServiceLayer.Models;
using System.Data;
using DomainLayer.Models;
//using DomainLayer.Interfaces;

namespace Marketplace_OA.Controllers
{
    public class ProductController : Controller
    {

        //code for category
        public IMainCategoriesService _mainCategoriesService;
        public ICategoriesService _categoriesService;
        // code for product details and attributes
        public IProductGetAttributeService _productsService;


        //code for product attributes
        public IProductAttributesService ProductAttributesService;

        public IAttributesService _attributesService;
        private Mapper mapper;

        public ProductController()
        {
            ProductAttributesService = new ProductAttributesService();

            _mainCategoriesService = new MCService();
            _categoriesService = new MCService();
            _productsService = new MCService();
            _attributesService = new MCService();


            //using automapper 
            var config = new MapperConfiguration(cfg =>
            {
                // Configuring Map
                cfg.CreateMap<Product_AttributesDTO, ProductAttributesVM>();


                cfg.CreateMap<ProductAttributeDetailDTO, ProductAttributeDetailVM>();
                cfg.CreateMap<ProductsDTO, ProductsVM>();
                cfg.CreateMap<MainCategoriesDTO, MainCategoriesVM>();
                cfg.CreateMap<CategoriesDTO, CategoriesVM>();
                // Any Other Mapping Configuration ....
            });
            // Create an Instance of Mapper and return that Instance
            mapper = new Mapper(config);
        }

        public ActionResult ProductDetail(string mainCategory, string subCategory, int subCategoryId, int id)
        {
            int ProductID = id;
            var productAttribute = mapper.Map<List<ProductAttributesVM>>(ProductAttributesService.GetProductAttributes(ProductID));

            //List<ProductAttributeDetailVM> productDetailVM = new List<ProductAttributeDetailVM>();
            //var productDetail = _productsService.GetProductById(ProductID);
            //foreach (var product in productDetail)
            //{
            //    productDetailVM.Add(new ProductAttributeDetailVM
            //    {
            //        ProductsID = product.ProductsID,
            //        Product_Name = product.Product_Name,
            //        Description = product.Description,
            //        CategoriesID = product.CategoriesID,
            //        AttributesID = product.AttributesID,
            //        Attribute_Name = product.Attribute_Name,
            //        Attribute_Value = product.Attribute_Value,
            //    });
            //}

            //try DTO VM
            var productDetailVM = mapper.Map<List<ProductAttributeDetailVM>>(_productsService.GetProductById(ProductID));

            ViewBag.mainCategory = mainCategory;
            ViewBag.subCategory = subCategory;
            ViewBag.subCategoryId = subCategoryId;
            ViewBag.ProductDetail = productDetailVM;
            ViewBag.ProductAttributes = productAttribute;
            return View();

        }

        


        public ActionResult ProductCompare(string ids)
        {
            var productIds = ids.Split(',').Select(int.Parse).ToList();
            ViewBag.ProductIds = productIds;
            return View();
        }


        // GET: SearchPage
        public ActionResult Search()
        {
            return View();
        }

      

        // Method called from Search View to get Main category
        public JsonResult GetMainCategories()
        {

            //var mainCategories = _mainCategoriesService.GetAllMainCategories();
            ////var mainCategoriesVM = _mapper.Map<List<MainCategoriesVM>>(mainCategories);
            //List<MainCategoriesVM> mainCategoriesVM = new List<MainCategoriesVM>();

            //foreach (var mainCategory in mainCategories)
            //{
            //    mainCategoriesVM.Add(new MainCategoriesVM
            //    {
            //        MainCategoriesID = mainCategory.MainCategoriesID,
            //        Main_Category_Name = mainCategory.Main_Category_Name,
            //    });
            //}

            //try DTO
            var mainCategoriesVM = mapper.Map<List<MainCategoriesVM>>(_mainCategoriesService.GetAllMainCategories());
            return Json(mainCategoriesVM, JsonRequestBehavior.AllowGet);
        }

        // Method called from Search View to get Subcategory
        public JsonResult GetSubCategories(int MainCategoryId)
        {

            //var Category = _categoriesService.GetCategoryById(MainCategoryId);
            //List<CategoriesVM> CategoriesVM = new List<CategoriesVM>();
            //foreach (var category in Category)
            //{
            //    CategoriesVM.Add(new CategoriesVM
            //    {
            //        CategoriesID = category.CategoriesID,
            //        Category_Name = category.Category_Name,
            //        MainCategoriesID = category.MainCategoriesID,
            //    });
            //}

            //try DTO
            var CategoriesVM = mapper.Map<List<CategoriesVM>>(_categoriesService.GetCategoryById(MainCategoryId));
            return Json(CategoriesVM, JsonRequestBehavior.AllowGet);
        }

        // show product list page based on subcategory
        [HttpPost]
        public ActionResult Search(string mainCategory, string subCategory, int subCategoryId)
        {

            var maincategory = mainCategory;
            var subcategory = subCategory;
            var subcategoryid = subCategoryId;
            // Redirect to the ProductList action to display the results
            return RedirectToAction("ProductList", new { mainCategory = maincategory, subCategory = subcategory, subCategoryId = subcategoryid });
        }

        public ActionResult ProductList(string mainCategory, string subCategory, int subCategoryId)
        {

            int CategoryId = subCategoryId;
            //var products = _productsService.GetProductsByCategory(CategoryId);
            //List<ProductsVM> productsVM = new List<ProductsVM>();
            //foreach (var product in products)
            //{
            //    productsVM.Add(new ProductsVM
            //    {
            //        ProductsID = product.ProductsID,
            //        Product_Name = product.Product_Name,
            //        Description = product.Description,
            //        CategoriesID = product.CategoriesID,
            //        Image_URL = product.Image_URL,
            //    });
            //}

            //try DTO VM

            var productsVM = mapper.Map<List<ProductsVM>>(_productsService.GetProductsByCategory(CategoryId));


            //get product details
            List<ProductAttributeDetailVM> productDetailVM = new List<ProductAttributeDetailVM>();
            foreach (var item in productsVM)
            {   //get product id
                var product_id = item.ProductsID;
                var productDetail = _productsService.GetProductById(product_id);

                foreach (var product in productDetail)
                {
                    productDetailVM.Add(new ProductAttributeDetailVM
                    {
                        ProductsID = product.ProductsID,
                        Product_Name = product.Product_Name,
                        Description = product.Description,
                        CategoriesID = product.CategoriesID,
                        AttributesID = product.AttributesID,
                        Attribute_Name = product.Attribute_Name,
                        Attribute_Value = product.Attribute_Value,

                    });
                }
            }

            //try DTO VM
            //var productDetailVM = mapper.Map<List<ProductAttributeDetailVM>>(_productsService.GetProductById(product_id));


            ViewBag.mainCategory = mainCategory;
            ViewBag.subCategory = subCategory;
            ViewBag.subCategoryId = subCategoryId;
            //ViewBag.mainCategory = "Mechanical";
            //ViewBag.subCategory = "Car Battery";
            //ViewBag.subCategoryId = 1;
            ViewBag.productsVM = productsVM;
            ViewBag.productDetailVM = productDetailVM;

            return View();
        }

        

        public ActionResult testFilter(List<FilterCriteria> filter)
        {
            int subCategoryId = 1;
            filter = new List<FilterCriteria>();
            filter.Add(new FilterCriteria { AttributeId = 1, MinValue = 10, MaxValue = 100 });
            filter.Add(new FilterCriteria { AttributeId = 2, MinValue = 1, MaxValue = 3 });
            filter.Add(new FilterCriteria { AttributeId = 3, MinValue = 14, MaxValue = 20 });
            filter.Add(new FilterCriteria { AttributeId = 4, MinValue = 11, MaxValue = 15 });
            Filters filters = new Filters();
                
            var table = filters.GetFilteredProducts(subCategoryId, filter);
            //var test = filters.TestSimpleQuery();
            return View(table);
        }

        public ActionResult GetAttributes(int subCategoryId = 1)
        {
            var attributes = _attributesService.GetAttributesByCategoryId(subCategoryId);
            List<AttributesVM> attributesVM = new List<AttributesVM>();
            foreach (var attribute in attributes)
            {
                attributesVM.Add(new AttributesVM
                {
                    AttributesID = attribute.AttributesID,
                    Attribute_Name = attribute.Attribute_Name,
                    min_value = attribute.min_value,
                    max_value  = attribute.max_value,
                    Value_Type  = attribute.Value_Type,
                    CategoriesID = attribute.CategoriesID,
                });
            }

            return View(attributesVM);
            
        }
    }
}









