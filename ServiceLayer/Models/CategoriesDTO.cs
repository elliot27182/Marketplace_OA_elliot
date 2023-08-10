using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class CategoriesDTO
    {
        public int CategoriesID { get; set; }
        public string Category_Name { get; set; }
        public Nullable<int> MainCategoriesID { get; set; }

    }
}
