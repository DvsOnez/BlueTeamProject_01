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
        Order order = new Order();
        MenuGrv menu = new MenuGrv();
        public BindingSource bsBeverage { get; set; }

        public Beverage()
        {
            InitializeComponent();
            bsBeverage = new BindingSource();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADD_Click(object sender, EventArgs e) {
            Product product = new Product();
            order.currentShop.OrderProducts.Add(product);
        }

        private void Beverage_Load(object sender, EventArgs e) {
            bsBeverage.DataSource = menu.CurrentShop.Products;
            BeverageGrid.DataSource = bsBeverage;
        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
