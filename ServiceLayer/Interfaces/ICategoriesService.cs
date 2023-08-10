using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Models;

namespace ServiceLayer.Interfaces
{

    public interface ICategoriesService
    {
        //IEnumerable<CategoriesDTO> GetCategory();
        IEnumerable<CategoriesDTO> GetCategoryById(int MainCategoryId);
    }

}