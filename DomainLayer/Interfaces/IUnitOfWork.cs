using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

        IProductsRepo ProductsRepo { get; }
        IUsersRepo UsersRepo { get; }
        ICategoriesRepo CategoriesRepo { get; }
        IAttributesRepo AttributesRepo { get; }
        IAttributesValuesRepo AttributesValueRepo { get; }
        IProductAttributesRepo ProductAttributesRepo { get; }
        IMainCategoriesRepo MainCategoriesRepo { get; }

        IProductsAttributesRepo2 ProductsAttributesRepo { get; }

        int Save();
    }
}
