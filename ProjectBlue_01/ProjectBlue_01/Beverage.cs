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

namespace CoffeeShopForms
{
    public partial class Beverage : Form
    {
        public CoffeeShop CurrentShop { get; set; }
        public BindingSource bsProducts { get; set; }
        Order order = new Order();
        public Beverage()
        {
            InitializeComponent();
            bsProducts = new BindingSource();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Beverage_Load(object sender, EventArgs e)
        {
            CurrentShop.LoadProduct();
            bsProducts.DataSource = CurrentShop.Products.FindAll(prod => prod.ProductType.ToString() == "Beverage");
            grdBeverage.DataSource = bsProducts.DataSource;
            grvBeverage.Columns["ProductCategoryID"].Visible = false;
            grvBeverage.Columns["ID"].Visible = false;
            bsProducts.ResetBindings(true);
        }

        private void ADD_Click(object sender, EventArgs e) {
            Product product = new Product();
            order.CurrentShop.Basket.Add(product);
        }
    }
}
