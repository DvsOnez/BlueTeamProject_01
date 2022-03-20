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
    public partial class Completion : Form
    {
        public CoffeeShop CurrentShop { get; set; }

        public BindingSource bsOrder { get; set; }

        public Completion()
        {
            InitializeComponent();
            bsOrder = new BindingSource();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Confirm", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
             if (res == DialogResult.OK)
            {
                MessageBox.Show("You order is Confirmed");

            }
             if (res == DialogResult.Cancel)
            {
                MessageBox.Show("Your Order is Canceled");
            }
        }

        private void Completion_Load(object sender, EventArgs e) {

            grdOrder.DataSource = CurrentShop.Basket;
            grvOrder.Columns["ProductCategoryID"].Visible = false;
            grvOrder.Columns["ID"].Visible = false;
            bsOrder.ResetBindings(true);
        }
    }
}
