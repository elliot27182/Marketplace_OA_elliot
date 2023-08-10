using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using ServiceLayer.Models;


namespace ServiceLayer.Interfaces


{

    public interface IAttributesService 
    {
        IEnumerable<AttributesDTO> GetAttributesByCategoryId(int attributeId);
    }

}
