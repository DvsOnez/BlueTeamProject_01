using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class TransactionLine
    {
        private const double discLimit = 10;
        private const double discRate = 0.15;
        public Guid ID { get; }
        public Guid ProductID { get; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Discount { get; set; }
        public double TotalPrice { get; set; }
        public double LineCost { get; set; }
        public int Quantity { get; set; }
        //public string LineStr { get; set; }

        public TransactionLine(int quantity, Product product)
        {
            ID = Guid.NewGuid();
            Discount = false;
            Price = GetPrice(quantity, product);
            Quantity = quantity;
            Description = product.Description;
            TotalPrice = GetTotalPrice(quantity, product);
            //LineStr = product.Description + " x" + quantity + " :  " + Price.ToString() + "\n";
        }

        public double  GetPrice(int quantity, Product product)
        {
            return quantity * product.Price;
        }
        //public  GetPrice(int quantity, Product product)
        //{
        //    Price = quantity * product.Price;
        //}
        public void GetCost(int quantity, Product product)
        {
            LineCost = quantity * product.Cost;
        }
        public double GetTotalPrice(int quantity, Product product)
        {
            double price = GetPrice(quantity, product);
            if (price < discLimit)
            {
                return price;
            }
            else
            {
                Discount = true;
                //return (price - (price * discRate));
                return price;
            }
        }

        public void ApplyDisc() {
            TotalPrice = (Price - (Price * discRate));
        }
        //public void GetTotalPrice(double price)
        //{
        //    if (price > discLimit)
        //    {
        //        Price = (Price - (Price * discRate));
        //    }
        //    else
        //        Price = price;
        //}
        //public void GetTotalPrice(int quantity, Product product) {
        //    double price = GetPrice(quantity, product);

        //    if (price > discLimit) {
        //        Price = Price - (Price * discRate);
        //    }
        //    else
        //        Price = price;
        //}
    }
}
