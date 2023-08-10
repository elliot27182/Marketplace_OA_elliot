using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ProductAttributeDetail
    {
        public int ProductsID { get; set; }
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public int CategoriesID { get; set; }
        public int AttributesID { get; set; }
        public string Attribute_Name { get; set; }
        public int Attribute_ValuesID { get; set; }
        public string Attribute_Value { get; set; }
    }
}
