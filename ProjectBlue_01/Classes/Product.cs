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

    public class Coffee : Product
    {
        public const string FILE_NAME = "CoffeeStorage.json";
        public List<Product> Caffees { get; set; }
        public Coffee()
        {

        }

        public void AddNewCoffee(Product product)
        {
           Caffees.Add(product);
        }
    }

    public class Beverage : Product
    {
        public const string FILE_NAME = "BeverageStorage.json";
        public List<Product> Beverages { get; set; }
        public Beverage()
        {

        }

        public void AddNewBeverage(Product product)
        {
            Beverages.Add(product);
        }
    }

    public class Food : Product
    {
        public const string FILE_NAME = "FoodStorage.json";
        public List<Product> Foods { get; set; }
        public Food()
        {

        }
        public void AddNewFood(Product product)
        {
            Foods.Add(product);
        }
    }
}
