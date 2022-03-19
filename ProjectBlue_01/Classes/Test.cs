using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    /// <summary>
    /// TODO:!!!delete this!!! THIS IS A TEST CLASS MUST BE DELETED 
    /// </summary>
    internal class Test
    {
        public Test()
        {

        }
        public string category;
        public void AddCoffeeTest()
        {
            //ProductCategory productCategory = new ProductCategory();
            //productCategory.
            //category = "coffee";
            //ProductCategory(category, product);

            Product product = new Product();
            product.Description = "espresso";
            product.Cost = 0.40;
            product.Price = 1.5;
            product.Code = "001";
            string productType = "Coffee";  //ProductTypeEnum.Coffee.ToString();
            ProductCategory productCategory = new ProductCategory();
            productCategory.ChooseCategory(productType, product);

        }

        private static void AddNewFood(Product product)
        {
            AddNewBeverage(product);
            Product product1 = new Product();
            product.Description = "Olive Bread";
            product.Cost = 1.20;
            product.Price = 2.5;
            product.Code = "010";
        }

        private static void AddNewBeverage(Product product)
        {
            Product product2 = new Product();
            product.Description = "Tea";
            product.Cost = 0.20;
            product.Price = 1.5;
            product.Code = "005";
        }
    }
}
