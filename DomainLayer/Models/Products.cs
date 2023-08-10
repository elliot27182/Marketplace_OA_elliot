using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Products
    {
        public int ProductsID { get; set; }
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public string Image_URL { get; set; }
        public Nullable<int> CategoriesID { get; set; }

        public virtual Categories Categories { get; set; }

        public virtual ICollection<Product_Attributes> Product_Attributes { get; set; }
    }
}
