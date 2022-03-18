using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Product : Base
    {
        //public Guid Id { get; set; }
        //public string Code { get; set; }
        //public string Description { get; set; }
        public Guid ProductID { get; set; }
        public double Price { get; set; }
        //this I dont know the use of
        public double Cost { get; set; }

        public Product()
        {

        }
    }
}
