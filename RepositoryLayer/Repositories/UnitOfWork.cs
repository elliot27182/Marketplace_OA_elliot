using DomainLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using System.Runtime.Remoting.Contexts;

namespace RepositoryLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MarketDBContext _context;

        public IMainCategoriesRepo MainCategoriesRepo { get; }
        public IAttributesRepo AttributesRepo { get; }
        public IAttributesValuesRepo AttributesValueRepo { get; }
        public IProductsRepo ProductsRepo { get; }
        public ICategoriesRepo CategoriesRepo { get; }
        public IUsersRepo UsersRepo { get; }
        public IProductAttributesRepo ProductAttributesRepo { get; }

        public IProductsAttributesRepo2 ProductsAttributesRepo { get; }

        public UnitOfWork(MarketDBContext context)
        {
            _context = context;
            MainCategoriesRepo = new MainCategoriesRepo(_context);
            AttributesRepo = new AttributesRepo(_context);
            AttributesValueRepo = new AttributesValueRepo(_context);
            ProductsRepo = new ProductsRepo(_context);
            CategoriesRepo = new CategoriesRepo(_context);
            UsersRepo = new UsersRepo(_context);
            ProductAttributesRepo = new ProductAttributesRepo(_context);

            ProductsAttributesRepo = new ProductAttributesRepo2(_context);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }



    }
}
