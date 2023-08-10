using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class FilterCriteriaVM
    {
        public int AttributeId { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
    }
}
