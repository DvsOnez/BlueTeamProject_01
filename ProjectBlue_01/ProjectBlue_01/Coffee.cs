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
    public partial class Coffee : Form
    {
        public CoffeeShop CurrentShop { get; set; }
        public BindingSource bsProducts { get; set; }
        public Coffee()
        {
            InitializeComponent();
            bsProducts = new BindingSource();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Coffee_Load(object sender, EventArgs e)
        {
            CurrentShop.LoadProduct();
            bsProducts.DataSource = CurrentShop.Products.FindAll(prod => prod.ProductType.ToString() == "Coffee");
            grdCoffee.DataSource = bsProducts.DataSource;
            bsProducts.ResetBindings(true);


        }
    }
}
