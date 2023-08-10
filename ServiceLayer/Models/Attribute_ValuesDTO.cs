using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class Attribute_ValuesDTO
    {
        public int Attribute_Value_ID { get; set; }
        public Nullable<int> Attribute_ID { get; set; }
        public string Attribute_Value { get; set; }

        public virtual AttributesDTO Attributes { get; set; }
        
        public virtual ICollection<Product_AttributesDTO> Product_Attributes { get; set; }
    }

}
