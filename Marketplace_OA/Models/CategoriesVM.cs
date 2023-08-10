using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace_OA.Models
{
    public class CategoriesVM
    {
        public int CategoriesID { get; set; }
        public string Category_Name { get; set; }
        public Nullable<int> MainCategoriesID { get; set; }

    }
}