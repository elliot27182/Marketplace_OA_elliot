using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{

    public interface ICategoriesRepo : IGenericRepo<Categories>
    {
        IEnumerable<Categories> GetCategoryById(int MainCategoryId);
    }

}