using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer : Base
    {
        //public Guid CustomerID { get; set; }
        //public string CustomerCode { get; set; }
        //public string Description { get; set; }

        public Customer()
        {

        }

        //basket: store products for customer
      
        public void Basket(Product product)
        {
            List<Product> basket = new List<Product>();
            basket.Add(product);

            // just in case
            // discount and totalPrice calculation method
            //Discount(basket);
        }



        //double totalPrice;
        //public const double DISCOUNT = 0.15;
        //public double totalDiscount;
        //private void Discount(List<Product> basket)
        //{
        //    foreach (Product Item in basket)
        //    {
        //        totalPrice = totalPrice + Item.Price;
        //    }
        //    if (totalPrice > 10)
        //    {
        //        foreach (Product Item in basket)
        //        {
        //            totalDiscount = Item.Price * DISCOUNT;
        //        }
        //    }
        //}
    }
}

