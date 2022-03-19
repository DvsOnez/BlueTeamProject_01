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
        public double Price { get; set; } 
        public double Discount { get; set; }
        public double TotalPrice { get; set; }

        public TransactionLine()
        {
            ID = Guid.NewGuid();
        }

        public double GetPrice(int quantity, Product product)
        {
            //Price = quantity * product.Price;
            return quantity * product.Price;
        }

        public double GetTotalPrice(double price) {
            if (price < 10)
            {
                return price;
            }
            else
                return price - (price * 0.15);
        }
    }
}
