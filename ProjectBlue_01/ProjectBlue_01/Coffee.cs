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
        Order order = new Order();

        public Coffee()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADD_Click(object sender, EventArgs e) {
            Product product = new Product();
            order.currentShop.OrderProducts.Add(product);
        }
    }
}
