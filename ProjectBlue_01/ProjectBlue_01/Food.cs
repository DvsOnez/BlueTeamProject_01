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
    public partial class Food : Form
    {
        //public CoffeeShop currentShop { get; set; }
        public BindingSource bsFood { get; set; }
        Order order = new Order();

        public Food()
        {
            InitializeComponent();
            bsFood = new BindingSource();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADD_Click(object sender, EventArgs e) {
            Product product = new Product();
            order.currentShop.OrderProducts.Add(product);
        }

        private void gridControl1_Click(object sender, EventArgs e) {

        }
    }
}
