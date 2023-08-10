using RepositoryLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using DomainLayer.Interfaces;

namespace RepositoryLayer
{
    public class AttributesRepo : GenericRepo<Attributes>, IAttributesRepo
    {
        public AttributesRepo(MarketDBContext context) : base(context)
        {
        }

        public IEnumerable<Attributes> GetAttributesByCategoryId(int categoriesId)
        {
            var attributes = Context.Set<Attributes>().Where(attribute => attribute.CategoriesID == categoriesId);
            return attributes.ToList();

        }
    }

}
