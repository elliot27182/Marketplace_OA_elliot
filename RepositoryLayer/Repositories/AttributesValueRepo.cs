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
    public class AttributesValueRepo : GenericRepo<Attribute_Values>, IAttributesValuesRepo
    {
        public AttributesValueRepo(MarketDBContext context) : base(context)
        {
        }
    }

}

