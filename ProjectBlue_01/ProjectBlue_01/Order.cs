using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopForms{
    
        public partial class Order : Form
       
    {
        private Completion Completion;
        private Coffee coffee;
        private Beverage beverage;
        private Food food;

        public CoffeeShop currentShop { get; set; }

        public Order()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
           Completion completion = new Completion();
           completion.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CoffeeButton_Click(object sender, EventArgs e)
        {
            coffee = new Coffee();
            coffee.ShowDialog();

        }

        private void BeverageButton_Click(object sender, EventArgs e)
        {
            beverage = new Beverage();
            beverage.ShowDialog();
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            food = new Food();
            food.ShowDialog();
        }

        private void Order_Load(object sender, EventArgs e) {
            //Mock product data
            Product freddo = new Product() {
                ID = Guid.NewGuid(),
                Code = "1",
                Description = "freddo",
                Price = 2.0,
                Cost = 0.5,
                ProductCategoryID = 222
            };
            Product tea = new Product() {
                ID = Guid.NewGuid(),
                Code = "2",
                Description = "tea",
                Price = 1.5,
                Cost = 0.3,
                ProductCategoryID = 222

            };
            Product cookie = new Product() {
                ID = Guid.NewGuid(),
                Code = "3",
                Description = "cookie",
                Price = 2.5,
                Cost = 1,
                ProductCategoryID = 222
            };
            currentShop.Products.Add(freddo);
            currentShop.Products.Add(tea);
            currentShop.Products.Add(cookie);
        }
    }
}
