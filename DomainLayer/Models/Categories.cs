using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Categories
    {
        public int CategoriesID { get; set; }
        public string Category_Name { get; set; }
        public Nullable<int> MainCategoriesID { get; set; }


        public virtual MainCategories MainCategories { get; set; }

        public virtual ICollection<Products> Products { get; set; }

        public virtual ICollection<Attributes> Attributes { get; set; }
    }
}
