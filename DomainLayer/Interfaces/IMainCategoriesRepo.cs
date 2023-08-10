﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace DomainLayer.Interfaces
{
    public interface IMainCategoriesRepo : IGenericRepo<MainCategories>
    {
        IEnumerable<Categories> GetCategoriesByMainCategoryId(int mainCategoryId);
    }
}