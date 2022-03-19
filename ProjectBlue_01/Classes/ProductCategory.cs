using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum ProductTypeEnum
    {
        Coffee = 0,
        Beverages = 1,
        Food = 2,
    }
    public class ProductCategory : Base
    {

        public ProductCategory()
        {

        }
        public void ChooseCategory(string productType,Product product)
        {
            if (productType == ProductTypeEnum.Coffee.ToString())
            {
                Coffee coffee = new Coffee();
                coffee.AddNewCoffee(product);
            }
            else if (productType == ProductTypeEnum.Beverages.ToString())
            {
                Beverage beverage = new Beverage();
                beverage.AddNewBeverage(product);
            }
            else if (productType == ProductTypeEnum.Food.ToString())
            {
                Food food = new Food();
                food.AddNewFood(product);
            }
            
        }
    }
}
