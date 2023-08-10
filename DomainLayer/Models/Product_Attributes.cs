using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Product_Attributes
    {
        public int ProductsID { get; set; }
        public int AttributesID { get; set; }
        public Nullable<int> Discrete_Attribute_Value_ID { get; set; }
        public Nullable<double> Min_Continuous_Attribute_Value { get; set; }
        public Nullable<double> Max_Continuous_Attribute_Value { get; set; }

        public virtual Attribute_Values Attribute_Values { get; set; }
        public virtual Attributes Attributes { get; set; }
        public virtual Products Products { get; set; }
    }
}
