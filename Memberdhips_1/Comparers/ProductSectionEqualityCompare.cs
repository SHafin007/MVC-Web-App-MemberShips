using Memberdhips_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Memberdhips_1.Comparers
{
    public class ProductSectionEqualityCompare : IEqualityComparer<ProductSection>
    {
        public bool Equals(ProductSection section1, ProductSection section2)
        {
            return section1.Id.Equals(section2.Id);
        }

        public int GetHashCode(ProductSection section)
        {
            return (section.Id).GetHashCode();
        }
    }
}