using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{

    public interface IAttributesRepo : IGenericRepo<Attributes>
    {
        IEnumerable<Attributes> GetAttributesByCategoryId(int attributeId);
    }

}
