using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class Product_AttributesDTO
    {

        public int ProductsID { get; set; }
        public int AttributesID { get; set; }
        public string Attribute_Name { get; set; }
        public Nullable<int> Attribute_Value_ID { get; set; }
        public string Attribute_Value { get; set; }
        public string Value_Type { get; set; }

        //public string Product_Name { get; set; }
        //public string Description { get; set; }
        //public string Image_URL { get; set; }
    }
}
