﻿using System;
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

        
    }
}
