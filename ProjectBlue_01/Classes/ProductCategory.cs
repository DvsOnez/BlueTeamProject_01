using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum ProductTypeEnum
    {
        //Coffee = 0,
        //Beverages = 1,
        //Food = 2,
        Coffee,
        Beverages,
        Food,
    }
    public class ProductCategory : Base {

        public int ID { get; set; } 
        public ProductCategory() : base() {
            ID = 0;
        }
        //public void ChooseCategory(string productType,Product product)
        //{
        //    if (productType == ProductTypeEnum.Coffee.ToString())
        //    {
        //        Coffee coffee = new Coffee();
        //        coffee.AddNewCoffee(product);
        //    }
        //    else if (productType == ProductTypeEnum.Beverages.ToString())
        //    {
        //        Beverage beverage = new Beverage();
        //        beverage.AddNewBeverage(product);
        //    }
        //    else if (productType == ProductTypeEnum.Food.ToString())
        //    {
        //        Food food = new Food();
        //        food.AddNewFood(product);
        //    }

        //}

        public ProductTypeEnum productType;
        ProductCategory HotStuff = new ProductCategory() {
            ID = 222,
            Code = "111",
            Description = "Hot Stuff",
            productType = ProductTypeEnum.Coffee
        };
    }
}
