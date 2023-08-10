using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Runtime.Remoting.Contexts;

namespace RepositoryLayer
{
    internal class seed
    {


        public void seedcreate()
        {
            // write your code here to add intial data

            // //*****Copy below code to Configuration.cs*****

            //var users = new List<Users>
            //{
            //    new Users {UsersID = 1, User_Name = "test", User_Email = "test@test", Password = "123"}
            //};
            //users.ForEach(s => context.Users.Add(s));
            //context.SaveChanges();


            //var mainCategories = new List<MainCategories>
            //{
            //    new MainCategories { MainCategoriesID = 1, Main_Category_Name = "Mechanical" },
            //    new MainCategories { MainCategoriesID = 2, Main_Category_Name = "Electrical" },
            //    new MainCategories { MainCategoriesID = 3, Main_Category_Name = "Stationery" },
            //    new MainCategories { MainCategoriesID = 4, Main_Category_Name = "Furniture" }
            //};
            //mainCategories.ForEach(s => context.MainCategories.Add(s));
            //context.SaveChanges();

            //var subCategories = new List<Categories>
            //{
            //    new Categories { CategoriesID = 1, Category_Name = "Car Battery", MainCategoriesID = 1 },
            //    new Categories { CategoriesID = 2, Category_Name = "Air Conditioner", MainCategoriesID = 1 },
            //    new Categories { CategoriesID = 3, Category_Name = "Desk Lamp", MainCategoriesID = 2 },
            //    new Categories { CategoriesID = 4, Category_Name = "Electric Drill", MainCategoriesID = 2 },
            //    new Categories { CategoriesID = 5, Category_Name = "Fountain Pen", MainCategoriesID = 3 },
            //    new Categories { CategoriesID = 6, Category_Name = "Spiral Notebook", MainCategoriesID = 3 },
            //    new Categories { CategoriesID = 7, Category_Name = "Office Chair", MainCategoriesID = 4 },
            //    new Categories { CategoriesID = 8, Category_Name = "Sofa", MainCategoriesID = 4 }
            //};
            //subCategories.ForEach(s => context.Categories.Add(s));
            //context.SaveChanges();

            ////// one formate for attribtues table, unique attributes, one attributes may belong to many categories
            ////var attributes = new List<Attributes>
            ////{
            ////    new Attributes { AttributesID = 1, Attribute_Name = "Capacity (Ah)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 2, Attribute_Name = "Warranty (Years)", min_value = 0, max_value = 100, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 3, Attribute_Name = "Weight (Kg)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 4, Attribute_Name = "Voltage (V)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 5, Attribute_Name = "Brand", Value_Type = "String" },
            ////    new Attributes { AttributesID = 6, Attribute_Name = "Type", Value_Type = "String" },
            ////    new Attributes { AttributesID = 7, Attribute_Name = "BTU", min_value = 0, max_value = 100000, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 8, Attribute_Name = "Energy Efficiency Rating", min_value = 0, max_value = 10, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 9, Attribute_Name = "Noise Level (dB)", min_value = 0, max_value = 150, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 10, Attribute_Name = "Wattage (W)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 11, Attribute_Name = "Height (cm)", min_value = 0, max_value = 500, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 12, Attribute_Name = "Lifespan (Hours)", min_value = 0, max_value = 1000000, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 13, Attribute_Name = "Color", Value_Type = "String" },
            ////    new Attributes { AttributesID = 14, Attribute_Name = "Material", Value_Type = "String" },
            ////    new Attributes { AttributesID = 15, Attribute_Name = "Power (W)", min_value = 0, max_value = 10000, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 16, Attribute_Name = "Speed (RPM)", min_value = 0, max_value = 30000, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 17, Attribute_Name = "Cable Length (M)", min_value = 0, max_value = 100, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 18, Attribute_Name = "Length (cm)", min_value = 0, max_value = 500, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 19, Attribute_Name = "Weight (g)", min_value = 0, max_value = 10000, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 20, Attribute_Name = "Diameter (mm)", min_value = 0, max_value = 500, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 21, Attribute_Name = "Pages", min_value = 0, max_value = 10000, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 22, Attribute_Name = "Width (cm)", min_value = 0, max_value = 500, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 23, Attribute_Name = "Weight Capacity (Kg)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            ////    new Attributes { AttributesID = 24, Attribute_Name = "Depth (cm)", min_value = 0, max_value = 500, Value_Type = "Number" },
            ////};
            ////attributes.ForEach(s => context.Attributes.Add(s));
            ////context.SaveChanges();

            //// Another formate, each category 6 rows
            //var attributes2 = new List<Attributes>
            //{
            //    // Subcategory: Car Battery
            //    new Attributes { AttributesID = 1, Attribute_Name = "Capacity (Ah)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { AttributesID = 2, Attribute_Name = "Warranty (Years)", min_value = 0, max_value = 100, Value_Type = "Number" },
            //    new Attributes { AttributesID = 3, Attribute_Name = "Weight (Kg)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { AttributesID = 4, Attribute_Name = "Voltage (V)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { AttributesID = 5, Attribute_Name = "Brand", Value_Type = "Text" },
            //    new Attributes { AttributesID = 6, Attribute_Name = "Type", Value_Type = "Text" },

            //    // Subcategory: Air Conditioner
            //    new Attributes { AttributesID = 7, Attribute_Name = "BTU", min_value = 0, max_value = 30000, Value_Type = "Number" },
            //    new Attributes { AttributesID = 8, Attribute_Name = "Energy Efficiency Rating", min_value = 0, max_value = 10, Value_Type = "Number" },
            //    new Attributes { AttributesID = 9, Attribute_Name = "Weight (Kg)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { AttributesID = 10, Attribute_Name = "Noise Level (dB)", min_value = 0, max_value = 100, Value_Type = "Number" },
            //    new Attributes { AttributesID = 11, Attribute_Name = "Brand", Value_Type = "Text" },
            //    new Attributes { AttributesID = 12, Attribute_Name = "Type", Value_Type = "Text" },

            //// Subcategory: Desk Lamp
            //    new Attributes { AttributesID = 13, Attribute_Name = "Wattage (W)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { AttributesID = 14, Attribute_Name = "Height (cm)", min_value = 0, max_value = 200, Value_Type = "Number" },
            //    new Attributes { AttributesID = 15, Attribute_Name = "Weight (Kg)", min_value = 0, max_value = 100, Value_Type = "Number" },
            //    new Attributes { AttributesID = 16, Attribute_Name = "Lifespan (Hours)", min_value = 0, max_value = 100000, Value_Type = "Number" },
            //    new Attributes { AttributesID = 17, Attribute_Name = "Color", Value_Type = "Text" },
            //    new Attributes { AttributesID = 18, Attribute_Name = "Material", Value_Type = "Text" },

            //    // Subcategory: Electric Drill
            //    new Attributes { AttributesID = 19, Attribute_Name = "Power (W)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { AttributesID = 20, Attribute_Name = "Speed (RPM)", min_value = 0, max_value = 5000, Value_Type = "Number" },
            //    new Attributes { AttributesID = 21, Attribute_Name = "Weight (Kg)", min_value = 0, max_value = 100, Value_Type = "Number" },
            //    new Attributes { AttributesID = 22, Attribute_Name = "Cable Length (M)", min_value = 0, max_value = 50, Value_Type = "Number" },
            //    new Attributes { AttributesID = 23, Attribute_Name = "Color", Value_Type = "Text" },
            //    new Attributes { AttributesID = 24, Attribute_Name = "Material", Value_Type = "Text" },

            //    // Subcategory: Fountain Pen
            //    new Attributes { AttributesID = 25, Attribute_Name = "Length (cm)", min_value = 0, max_value = 50, Value_Type = "Number" },
            //    new Attributes { AttributesID = 26, Attribute_Name = "Weight (g)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { AttributesID = 27, Attribute_Name = "Diameter (mm)", min_value = 0, max_value = 50, Value_Type = "Number" },
            //    new Attributes { AttributesID = 28, Attribute_Name = "Warranty (Years)", min_value = 0, max_value = 100, Value_Type = "Number" },
            //    new Attributes { AttributesID = 29, Attribute_Name = "Color", Value_Type = "Text" },
            //    new Attributes { AttributesID = 30, Attribute_Name = "Material", Value_Type = "Text" },

            //    // Subcategory: Spiral Notebook
            //    new Attributes { AttributesID = 31, Attribute_Name = "Pages", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { AttributesID = 32, Attribute_Name = "Weight (g)", min_value = 0, max_value = 5000, Value_Type = "Number" },
            //    new Attributes { AttributesID = 33, Attribute_Name = "Width (cm)", min_value = 0, max_value = 50, Value_Type = "Number" },
            //    new Attributes { AttributesID = 34, Attribute_Name = "Height (cm)", min_value = 0, max_value = 50, Value_Type = "Number" },
            //    new Attributes { AttributesID = 35, Attribute_Name = "Color", Value_Type = "Text" },
            //    new Attributes { AttributesID = 36, Attribute_Name = "Material", Value_Type = "Text" },

            //    // Subcategory: Office Chair
            //    // Subcategory: Sofa
            //        // Subcategory: Office Chair
            //    new Attributes { AttributesID = 37, Attribute_Name = "Weight Capacity (Kg)", min_value = 0, max_value = 500, Value_Type = "Number" },
            //    new Attributes { AttributesID = 38, Attribute_Name = "Height (cm)", min_value = 0, max_value = 200, Value_Type = "Number" },
            //    new Attributes { AttributesID = 39, Attribute_Name = "Width (cm)", min_value = 0, max_value = 200, Value_Type = "Number" },
            //    new Attributes { AttributesID = 40, Attribute_Name = "Depth (cm)", min_value = 0, max_value = 200, Value_Type = "Number" },
            //    new Attributes { AttributesID = 41, Attribute_Name = "Color", Value_Type = "Text" },
            //    new Attributes { AttributesID = 42, Attribute_Name = "Material", Value_Type = "Text" },

            //    // Subcategory: Sofa
            //    new Attributes { AttributesID = 43, Attribute_Name = "Weight Capacity (Kg)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { AttributesID = 44, Attribute_Name = "Width (cm)", min_value = 0, max_value = 500, Value_Type = "Number" },
            //    new Attributes { AttributesID = 45, Attribute_Name = "Height (cm)", min_value = 0, max_value = 200, Value_Type = "Number" },
            //    new Attributes { AttributesID = 46, Attribute_Name = "Depth (cm)", min_value = 0, max_value = 500, Value_Type = "Number" },
            //    new Attributes { AttributesID = 47, Attribute_Name = "Color", Value_Type = "Text" },
            //    new Attributes { AttributesID = 48, Attribute_Name = "Material", Value_Type = "Text" },

            //};
            //attributes2.ForEach(s => context.Attributes.Add(s));
            //context.SaveChanges();


            //var products = new List<Products>
            //{
            //    new Products { ProductsID = 1, Product_Name = "Exide Car Battery 60 Ah", Description = "Exide Car Battery 60 Ah Description", Image_URL = "image1.png", CategoriesID = 1 },
            //    new Products { ProductsID = 2, Product_Name = "Amaron Car Battery 80 Ah", Description = "Amaron Car Battery 80 Ah Description", Image_URL = "image2.png", CategoriesID = 1 },
            //    new Products { ProductsID = 3, Product_Name = "Daikin Air Conditioner 12000 BTU", Description = "Daikin Air Conditioner 12000 BTU Description", Image_URL = "image3.png", CategoriesID = 2 },
            //    new Products { ProductsID = 4, Product_Name = "Samsung Air Conditioner 18000 BTU", Description = "Samsung Air Conditioner 18000 BTU Description", Image_URL = "image4.png", CategoriesID = 2 },
            //    new Products { ProductsID = 5, Product_Name = "Philips Desk Lamp 60 Watts", Description = "Philips Desk Lamp 60 Watts Description", Image_URL = "image5.png", CategoriesID = 3 },
            //    new Products { ProductsID = 6, Product_Name = "Ikea Desk Lamp 10 Watts", Description = "Ikea Desk Lamp 10 Watts Description", Image_URL = "image6.png", CategoriesID = 3 },
            //    new Products { ProductsID = 7, Product_Name = "Bosch Electric Drill 600 Watts", Description = "Bosch Electric Drill 600 Watts Description", Image_URL = "image7.png", CategoriesID = 4 },
            //    new Products { ProductsID = 8, Product_Name = "Black & Decker Electric Drill 550 Watts", Description = "Black & Decker Electric Drill 550 Watts Description", Image_URL = "image8.png", CategoriesID = 4 },
            //    new Products { ProductsID = 9, Product_Name = "Parker Fountain Pen", Description = "Parker Fountain Pen Description", Image_URL = "image9.png", CategoriesID = 5 },
            //    new Products { ProductsID = 10, Product_Name = "Montblanc Fountain Pen", Description = "Montblanc Fountain Pen Description", Image_URL = "image10.png", CategoriesID = 5 },
            //    new Products { ProductsID = 11, Product_Name = "Moleskine Spiral Notebook 200 Pages", Description = "Moleskine Spiral Notebook 200 Pages Description", Image_URL = "image11.png", CategoriesID = 6 },
            //    new Products { ProductsID = 12, Product_Name = "Oxford Spiral Notebook 100 Pages", Description = "Oxford Spiral Notebook 100 Pages Description", Image_URL = "image12.png", CategoriesID = 6 },
            //    new Products { ProductsID = 13, Product_Name = "Herman Miller Aeron Office Chair", Description = "Herman Miller Aeron Office Chair Description", Image_URL = "image13.png", CategoriesID = 7 },
            //    new Products { ProductsID = 14, Product_Name = "Steelcase Gesture Office Chair", Description = "Steelcase Gesture Office Chair Description", Image_URL = "image14.png", CategoriesID = 7 },
            //    new Products { ProductsID = 15, Product_Name = "Ashley Furniture Leather Sofa", Description = "Ashley Furniture Leather Sofa Description", Image_URL = "image15.png", CategoriesID = 8 },
            //    new Products { ProductsID = 16, Product_Name = "Ikea Ektorp Fabric Sofa", Description = "Ikea Ektorp Fabric Sofa Description", Image_URL = "image16.png", CategoriesID = 8 }
            //};
            //products.ForEach(s => context.Products.Add(s));
            //context.SaveChanges();

            //// only for first main category and its two subcategory products
            //var attributeValues = new List<Attribute_Values>
            //{
            //    // For Exide Car Battery
            //    new Attribute_Values { Attribute_ValuesID = 1, AttributesID = 1, Attribute_Value = "60" }, // Capacity (Ah)
            //    new Attribute_Values { Attribute_ValuesID = 2, AttributesID = 2, Attribute_Value = "3" }, // Warranty (Years)
            //    new Attribute_Values { Attribute_ValuesID = 3, AttributesID = 3, Attribute_Value = "15.2" }, // Weight (Kg)
            //    new Attribute_Values { Attribute_ValuesID = 4, AttributesID = 4, Attribute_Value = "12" }, // Voltage (V)
            //    new Attribute_Values { Attribute_ValuesID = 5, AttributesID = 5, Attribute_Value = "Exide" }, // Brand
            //    new Attribute_Values { Attribute_ValuesID = 6, AttributesID = 6, Attribute_Value = "Wet Battery" }, // Type

            //    // For Amaron Car Battery
            //    new Attribute_Values { Attribute_ValuesID = 7, AttributesID = 1, Attribute_Value = "80" }, // Capacity (Ah)
            //    new Attribute_Values { Attribute_ValuesID = 8, AttributesID = 2, Attribute_Value = "4" }, // Warranty (Years)
            //    new Attribute_Values { Attribute_ValuesID = 9, AttributesID = 3, Attribute_Value = "18.3" }, // Weight (Kg)
            //    new Attribute_Values { Attribute_ValuesID = 10, AttributesID = 4, Attribute_Value = "12" }, // Voltage (V)
            //    new Attribute_Values { Attribute_ValuesID = 11, AttributesID = 5, Attribute_Value = "Amaron" }, // Brand
            //    new Attribute_Values { Attribute_ValuesID = 12, AttributesID = 6, Attribute_Value = "Wet Battery" }, // Type

            //    // For Daikin Air Conditioner
            //    new Attribute_Values { Attribute_ValuesID = 13, AttributesID = 7, Attribute_Value = "12000" }, // BTU
            //    new Attribute_Values { Attribute_ValuesID = 14, AttributesID = 8, Attribute_Value = "9.5" }, // Energy Efficiency Rating
            //    new Attribute_Values { Attribute_ValuesID = 15, AttributesID = 9, Attribute_Value = "30" }, // Weight (Kg)
            //    new Attribute_Values { Attribute_ValuesID = 16, AttributesID = 10, Attribute_Value = "55" }, // Noise Level (dB)
            //    new Attribute_Values { Attribute_ValuesID = 17, AttributesID = 11, Attribute_Value = "Daikin" }, // Brand
            //    new Attribute_Values { Attribute_ValuesID = 18, AttributesID = 12, Attribute_Value = "Split System" }, // Type

            //    // For Samsung Air Conditioner
            //    new Attribute_Values { Attribute_ValuesID = 19, AttributesID = 7, Attribute_Value = "18000" }, // BTU
            //    new Attribute_Values { Attribute_ValuesID = 20, AttributesID = 8, Attribute_Value = "9" }, // Energy Efficiency Rating
            //    new Attribute_Values { Attribute_ValuesID = 21, AttributesID = 9, Attribute_Value = "35" }, // Weight (Kg)
            //    new Attribute_Values { Attribute_ValuesID = 22, AttributesID = 10, Attribute_Value = "57" }, // Noise Level (dB)
            //    new Attribute_Values { Attribute_ValuesID = 23, AttributesID = 11, Attribute_Value = "Samsung" }, // Brand
            //    new Attribute_Values { Attribute_ValuesID = 24, AttributesID = 12, Attribute_Value = "Split System" } // Type
            //};
            //attributeValues.ForEach(s => context.Attribute_Values.Add(s));
            //context.SaveChanges();


            //// only for first main category and its two subcategory products
            //var productAttributes = new List<Product_Attributes>
            //{
            //    // For Exide Car Battery
            //    new Product_Attributes { ProductsID = 1, AttributesID = 1, Discrete_Attribute_Value_ID = 1 }, // Capacity (Ah)
            //    new Product_Attributes { ProductsID = 1, AttributesID = 2, Discrete_Attribute_Value_ID = 2 }, // Warranty (Years)
            //    new Product_Attributes { ProductsID = 1, AttributesID = 3, Discrete_Attribute_Value_ID = 3 }, // Weight (Kg)
            //    new Product_Attributes { ProductsID = 1, AttributesID = 4, Discrete_Attribute_Value_ID = 4 }, // Voltage (V)
            //    new Product_Attributes { ProductsID = 1, AttributesID = 5, Discrete_Attribute_Value_ID = 5 }, // Brand
            //    new Product_Attributes { ProductsID = 1, AttributesID = 6, Discrete_Attribute_Value_ID = 6 }, // Type

            //    // For Amaron Car Battery
            //    new Product_Attributes { ProductsID = 2, AttributesID = 1, Discrete_Attribute_Value_ID = 7 }, // Capacity (Ah)
            //    new Product_Attributes { ProductsID = 2, AttributesID = 2, Discrete_Attribute_Value_ID = 8 }, // Warranty (Years)
            //    new Product_Attributes { ProductsID = 2, AttributesID = 3, Discrete_Attribute_Value_ID = 9 }, // Weight (Kg)
            //    new Product_Attributes { ProductsID = 2, AttributesID = 4, Discrete_Attribute_Value_ID = 10 }, // Voltage (V)
            //    new Product_Attributes { ProductsID = 2, AttributesID = 5, Discrete_Attribute_Value_ID = 11 }, // Brand
            //    new Product_Attributes { ProductsID = 2, AttributesID = 6, Discrete_Attribute_Value_ID = 12 }, // Type

            //    // For Daikin Air Conditioner
            //    new Product_Attributes { ProductsID = 3, AttributesID = 7, Discrete_Attribute_Value_ID = 13 }, // BTU
            //    new Product_Attributes { ProductsID = 3, AttributesID = 8, Discrete_Attribute_Value_ID = 14 }, // Energy Efficiency Rating
            //    new Product_Attributes { ProductsID = 3, AttributesID = 9, Discrete_Attribute_Value_ID = 15 }, // Weight (Kg)
            //    new Product_Attributes { ProductsID = 3, AttributesID = 10, Discrete_Attribute_Value_ID = 16 }, // Noise Level (dB)
            //    new Product_Attributes { ProductsID = 3, AttributesID = 11, Discrete_Attribute_Value_ID = 17 }, // Brand
            //    new Product_Attributes { ProductsID = 3, AttributesID = 12, Discrete_Attribute_Value_ID = 18 }, // Type

            //    // For Samsung Air Conditioner
            //    new Product_Attributes { ProductsID = 4, AttributesID = 7, Discrete_Attribute_Value_ID = 19 }, // BTU
            //    new Product_Attributes { ProductsID = 4, AttributesID = 8, Discrete_Attribute_Value_ID = 20 }, // Energy Efficiency Rating
            //    new Product_Attributes { ProductsID = 4, AttributesID = 9, Discrete_Attribute_Value_ID = 21 }, // Weight (Kg)
            //    new Product_Attributes { ProductsID = 4, AttributesID = 10, Discrete_Attribute_Value_ID = 22 }, // Noise Level (dB)
            //    new Product_Attributes { ProductsID = 4, AttributesID = 11, Discrete_Attribute_Value_ID = 23 }, // Brand
            //    new Product_Attributes { ProductsID = 4, AttributesID = 12, Discrete_Attribute_Value_ID = 24 } // Type
            //};
            //productAttributes.ForEach(s => context.Product_Attributes.Add(s));
            //context.SaveChanges();
        }


    }
}
