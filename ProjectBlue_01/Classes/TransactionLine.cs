using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class TransactionLine
    {
        public Guid ID { get; }
        public Guid ProductID { get; }
        public int Quantity { get; set; }
        public double Price { get; set; } // mipws de xreiazetai price
        public double Discount { get; set; }
        public double TotalPrice { get; set; }

        public TransactionLine()
        {
            ID = Guid.NewGuid();
        }

        public double GetPrice(int quantity, Product product)
        {
            return quantity; //* product.price;
        }

        public double GetTotal(int price) {
            if (price < 10)
            {
                return price;
            }
            else
                return price - (price * 0.15);
        }
    }
}
