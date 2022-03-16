using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class ProductCategory
    {
        public Guid ProductCategoryID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public ProductCategory()
        {

        }

        public enum ProductTypeEnum
        {
            Coffe=0,
            Beverages=1,
            Food =2,
        }
    }
}
