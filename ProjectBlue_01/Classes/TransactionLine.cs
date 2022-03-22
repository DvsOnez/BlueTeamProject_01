using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class TransactionLine
    {
        private const double DISCOUNT_LIMIT = 10;
        private const double DISCOUNT_RATE = 0.15;
        public Guid ID { get; }
        public Guid ProductID { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double TotalPrice { get; set; }
        //public double LineCost { get; set; }
        public int Quantity { get; set; }
        //public string LineStr { get; set; }


        public TransactionLine(int quantity, Product product)
        {
            ID = Guid.NewGuid();
            ProductID = product.ID;
            Description = product.Description;
            Quantity = quantity;
            Price = product.Price;
            Discount = product.Price * DISCOUNT_RATE;
            TotalPrice = Price * Quantity;

        }
        public bool GiveDiscount()
        {
            if (TotalPrice> DISCOUNT_LIMIT)
            {
                TotalPrice = (Price - Discount) * Quantity;
                return true;
            }
            Discount = 0;
            return false;
        }

        //public void AddTransactionLine(int quantity, Product product)
        //{
        //    TransactionLine transactionLine = new TransactionLine();
        //    transactionLine.ProductID = product.ID;
        //    transactionLine.Description = product.Description;
        //    transactionLine.Quantity = quantity;
        //    transactionLine.Price = product.Price;
        //    transactionLine.Discount = product.Price * DISCOUNT_RATE;
        //    transactionLine.TotalPrice = Price * Quantity;
        //}

        


        //public TransactionLine(int quantity, Product product)
        //{
        //    ID = Guid.NewGuid();
        //    Discount = false;
        //    Price = GetPrice(quantity, product);
        //    Quantity = quantity;
        //    Description = product.Description;
        //    TotalPrice = GetTotalPrice(quantity, product);
        //    //LineStr = product.Description + " x" + quantity + " :  " + Price.ToString() + "\n";
        //}

        //public double  GetPrice(int quantity, Product product)
        //{
        //    return quantity * product.Price;
        //}
        //public void GetCost(int quantity, Product product)
        //{
        //    LineCost = quantity * product.Cost;
        //}
        //public double GetTotalPrice(int quantity, Product product) // Discount should be checked by transaction, not here 
        //{                                                          // here only the method to return the reduced price
        //    double price = GetPrice(quantity, product);            // but tooo many problems, too little time to tackle all
        //    if (price < discLimit)
        //    {                                                      // I know it makes no sense this way, no time 
        //        return price;
        //    }
        //    else
        //    {
        //        Discount = true;
        //        //return (price - (price * discRate));
        //        return price;
        //    }
        //}

        //public void ApplyDisc() {
        //    TotalPrice = (Price - (Price * discRate));
        //}       
    }
}
