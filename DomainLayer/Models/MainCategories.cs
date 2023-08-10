using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class MainCategories
    {
        public int MainCategoriesID { get; set; }
        public string Main_Category_Name { get; set; }

        public virtual ICollection<Categories> Categories { get; set; }
    }
}
