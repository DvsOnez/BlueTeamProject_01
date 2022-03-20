﻿using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopForms
{
    public partial class Food : Form
    {

        public CoffeeShop CurrentShop { get; set; }
        public BindingSource bsProducts { get; set; }
        public Food()
        {
            InitializeComponent();
            bsProducts = new BindingSource();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Food_Load(object sender, EventArgs e)
        {
            CurrentShop.LoadProduct();
            bsProducts.DataSource = CurrentShop.Products.FindAll(prod => prod.ProductType.ToString() == "Food");
            grdFood.DataSource = bsProducts.DataSource;
            grvFood.Columns["ProductCategoryID"].Visible = false;
            grvFood.Columns["ID"].Visible = false;
            bsProducts.ResetBindings(true);
        }
<<<<<<< Updated upstream
=======

        private void ADD_Click(object sender, EventArgs e) {
            Product product = new Product();
            order.CurrentShop.OrderProducts.Add(product);
        }
>>>>>>> Stashed changes
    }
}
