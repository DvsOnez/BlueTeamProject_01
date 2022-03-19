using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Product : Base
    {
        public Guid ProductID { get; set; }
        public double Price { get; set; }
        //this I dont know the use of
        public double Cost { get; set; }

        public Product()
        {

        }
    }
}
